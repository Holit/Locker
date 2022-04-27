using Azylee.Core.DataUtils.EncryptUtils;
using Azylee.Core.DelegateUtils.ProcessDelegateUtils;
using Azylee.Core.IOUtils.FileUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Locker
{
    public class Attributes
    {
        public string UUID, Name, FriendlyName, Type, EncryptType, Password_MD5, Location, Description;
        long Size;
        int result = 0;
        bool is_initlized = false;
        /// <summary>
        /// 公共类：保存信息
        /// </summary>
        /// <param name="UUID">UUID</param>
        /// <param name="Name">源文件名</param>
        /// <param name="FriendlyName">友好名称</param>
        /// <param name="Size">大小</param>
        /// <param name="Type">源文件类型</param>
        /// <param name="Password_MD5">密码(MD5)</param>
        /// <param name="Location">位置</param>
        /// <param name="Description">描述</param>
        public void SetPropetries(string UUID, string Name, string FriendlyName, long Size, string Type, string Password_MD5, string Location, string Description)
        {
            this.Size = Size;
            this.UUID = UUID;
            this.Name = Name;
            this.FriendlyName = FriendlyName;
            this.Type = Type;
            this.Password_MD5 = Password_MD5;
            this.Location = Location;
            this.Description = Description;
            is_initlized = true;
        }
        public void SetPropetries(string UUID, string path, string FriendlyName, string Password, string Description)
        {
            this.UUID = UUID;
            Name = Path.GetFileNameWithoutExtension(path);
            Type = Path.GetExtension(path);
            Size = Azylee.Core.IOUtils.FileUtils.FileTool.Size(path);
            Location = path;
            this.FriendlyName = FriendlyName;
            Password_MD5 = Azylee.Core.DataUtils.EncryptUtils.MD5Tool.Encrypt(Password);
            this.Description = Description;

            is_initlized = true;
        }
        public string GetUUID()
        {
            if (is_initlized == true)
            {
                return UUID;
            }
            else
            {
                return null;
            }
        }
        public string GetName()
        {
            if (is_initlized == true)
            {
                return Name;
            }
            else
            {
                return null;
            }
        }
        public string GetFriendlyName()
        {
            if (is_initlized == true)
            {
                return FriendlyName;
            }
            else
            {
                return null;
            }
        }
        public long GetSize()
        {
            if (is_initlized == true)
            {
                return Size;
            }
            else
            {
                return 0;
            }
        }
        public string GetSrcType()
        {
            if (is_initlized == true)
            {
                return Type;
            }
            else
            {
                return null;
            }
        }
        public string GetPassword_MD5()
        {
            if (is_initlized == true)
            {
                return Password_MD5;
            }
            else
            {
                return null;
            }
        }
        public string GetLocation()
        {
            if (is_initlized == true)
            {
                return Location;
            }
            else
            {
                return null;
            }
        }
        public string GetDescription()
        {
            if (is_initlized == true)
            {
                return Description;
            }
            else
            {
                return null;
            }
        }
        public bool GetIsLoaded()
        {
            return is_initlized;
        }
        public void SetResult(int res)
        {
            result = res;
        }

        public int GetResult()
        {
            return result;
        }
    }
    public class Modules
    {
        public static string ReadTxtContent(string Path)
        {
            StreamReader sr = new StreamReader(Path, Encoding.Default);
            return sr.ReadToEnd();
        }
    }
    public class FileEncryptTool
    {
        const string FileType = "Jerry.Locker.Encrypted";//文件类型 禁止修改长度（22位）
        const string FileVersion = "100000";//类型的版本 禁止修改长度（6位）
        private const int FileBuffer = 1024*1024;

        public static string FileExt = ".locked";

        /// <summary>
        /// 文件加密
        /// </summary>
        /// <param name="srcFile">源文件</param>
        /// <param name="dstFile">目标文件</param>
        /// <param name="password">加密密码</param>
        /// <param name="progress">回调进度</param>
        /// <param name="overwrite">是否覆盖已有目标文件</param>
        /// <returns>
        /// >0：操作成功（操作共计秒数）
        /// -11：要加密的文件不存在
        /// -12：加密后的目标文件已存在
        /// -13：未知错误，操作失败
        /// -14：无法删除文件
        /// </returns>
        public static int Encrypt(bool is_DeleteAfterEncrypt, Attributes propetries, string srcFile, string dstFile, string password, ProgressDelegate.ProgressHandler progress = null, object sender = null, bool overwrite = true)
        {
            DateTime beginTime = DateTime.Now;
            if (!File.Exists(srcFile))
            {
                return -11; //要加密的文件不存在
            }

            if (File.Exists(dstFile) && !overwrite)
            {
                return -12;//加密后的目标文件已存在
            }

            string fmtPwd = AesTool.FmtPassword(password);
            string pwdMd5 = MD5Tool.Encrypt(MD5Tool.Encrypt(fmtPwd));

            string md5 = FileTool.GetMD5(srcFile);

            using (FileStream fsRead = new FileStream(srcFile, FileMode.Open))
            {
                using (FileStream fsWrite = new FileStream(dstFile, FileMode.Create))
                {
                    try
                    {
                        //写入文件类型标识和版本号
                        byte[] filetypeandversion = Encoding.Default.GetBytes(FileType + FileVersion);
                        fsWrite.Write(filetypeandversion, 0, filetypeandversion.Length);

                        List<byte[]> headdata = new List<byte[]>()
                            {
                                Encoding.Default.GetBytes(md5),     //文件MD5
                                Encoding.Default.GetBytes(propetries.GetUUID()),        //文件UUID
                                Encoding.Default.GetBytes(pwdMd5),
                                Encoding.Default.GetBytes(DateTime.Now.ToString()),
                                Encoding.Default.GetBytes(AesTool.Encrypt(propetries.GetName(),propetries.GetUUID())),
                                Encoding.Default.GetBytes(AesTool.Encrypt(propetries.GetFriendlyName(),propetries.GetUUID())),
                                Encoding.Default.GetBytes(AesTool.Encrypt(propetries.GetSize().ToString(),propetries.GetUUID())),
                                Encoding.Default.GetBytes(AesTool.Encrypt(propetries.GetSrcType(),propetries.GetUUID())),
                                Encoding.Default.GetBytes(AesTool.Encrypt(propetries.GetDescription(),propetries.GetUUID()))
                            };
                        //写入头部信息个数
                        byte[] count = BitConverter.GetBytes(headdata.Count);
                        fsWrite.Write(count, 0, count.Length);
                        //写入各部分长度
                        for (int i = 0; i < headdata.Count; i++)
                        {
                            byte[] length = BitConverter.GetBytes(headdata[i].Length);
                            fsWrite.Write(length, 0, length.Length);
                        }
                        //写入各部分数据
                        for (int i = 0; i < headdata.Count; i++)
                        {
                            fsWrite.Write(headdata[i], 0, headdata[i].Length);
                        }

                        //写入文件源数据
                        int readCount = 0;
                        byte[] buffer = new byte[FileBuffer];
                        while ((readCount = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            if (readCount != buffer.Length)
                            {
                                byte[] temp = new byte[readCount];
                                Buffer.BlockCopy(buffer, 0, temp, 0, readCount);
                                byte[] enbyte = AesTool.Encrypt(temp, fmtPwd);
                                fsWrite.Write(enbyte, 0, enbyte.Length);
                            }
                            else
                            {
                                byte[] enbyte = AesTool.Encrypt(buffer, fmtPwd);
                                fsWrite.Write(enbyte, 0, enbyte.Length);
                            }
                            progress?.Invoke(sender, new ProgressEventArgs(fsRead.Position, fsRead.Length));
                        }
                        //删除源文件
                        if (is_DeleteAfterEncrypt)
                        {
                            try
                            {
                                File.Delete(srcFile);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message.ToString(), "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                return -14;
                            }
                        }
                        return (int)Math.Ceiling((DateTime.Now - beginTime).TotalSeconds);//操作成功
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message.ToString(), "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return -13;
                    }
                }
            }
        }
        /// <summary>
        /// 文件解密
        /// </summary>
        /// <param name="srcFile">源文件</param>
        /// <param name="dstFile">目标文件</param>
        /// <param name="password">解密密码</param>
        /// <param name="progress">回调进度</param>
        /// <param name="overwrite">是否覆盖已有目标文件</param>
        /// <returns>
        /// >0：操作成功（操作共计秒数）
        /// -11：要解密的文件不存在
        /// -12：解密后的目标文件已存在
        /// -20：文件类型不匹配
        /// -30：文件头不长度不吻合
        /// -90：解锁密码错误
        /// -100：未知错误，操作失败
        /// </returns>
        public static Attributes Decrypt(string srcFile, string dstFile, string password, ProgressDelegate.ProgressHandler progress = null, object sender = null, bool overwrite = true)
        {
            Locker.Attributes ResultPropetries = new Attributes();

            DateTime beginTime = DateTime.Now;
            if (!File.Exists(srcFile))
            {
                ResultPropetries.SetResult(-11);

            }//要解密的文件不存在
            if (File.Exists(dstFile) && !overwrite)
            {
                ResultPropetries.SetResult(-12);
            }//解密后的目标文件已存在

            string fmtPwd = AesTool.FmtPassword(password);
            string pwdMd5 = MD5Tool.Encrypt(MD5Tool.Encrypt(fmtPwd));
            List<string> headdata = new List<string>();

            using (FileStream fsRead = new FileStream(srcFile, FileMode.Open))
            {
                byte[] filetype = Encoding.Default.GetBytes(FileType);
                fsRead.Read(filetype, 0, filetype.Length);
                string filetypestr = Encoding.Default.GetString(filetype);

                byte[] fileversion = Encoding.Default.GetBytes(FileVersion);
                fsRead.Read(fileversion, 0, fileversion.Length);
                string fileversionstr = Encoding.Default.GetString(fileversion);

                if (filetypestr != FileType && fileversionstr != FileVersion)
                {
                    ResultPropetries.SetResult(-20);
                }//文件类型不匹配

                //读取头部信息个数
                byte[] count = new byte[4];
                fsRead.Read(count, 0, count.Length);
                int countint = BitConverter.ToInt32(count, 0);
                //读取各部分长度和数据
                byte[] headlength = new byte[4 * countint];
                if (fsRead.Read(headlength, 0, headlength.Length) == headlength.Length)
                {
                    for (int i = 0; i < countint; i++)
                    {
                        int datalong = BitConverter.ToInt32(headlength, i * 4);
                        byte[] tempdata = new byte[datalong];
                        fsRead.Read(tempdata, 0, datalong);
                        headdata.Add(Encoding.Default.GetString(tempdata));
                    }
                }
                string file_MD5, UUID, pwd_MD5, SaveTime, AES_Name, AES_FriendlyName, AES_Size, AES_SrcType, AES_Description;
                file_MD5 = headdata[0];
                UUID = headdata[1];
                pwd_MD5 = headdata[2];
                SaveTime = headdata[3];
                //待AES解密的内容
                AES_Name = headdata[4];
                AES_FriendlyName = headdata[5];
                AES_Size = headdata[6];
                AES_SrcType = headdata[7];
                AES_Description = headdata[8];

                string Name, FriendlyName, Size, SrcType, Description;
                Name = AesTool.Decrypt(AES_Name, UUID);
                FriendlyName = AesTool.Decrypt(AES_FriendlyName, UUID);
                Size = AesTool.Decrypt(AES_Size, UUID);
                SrcType = AesTool.Decrypt(AES_SrcType, UUID);
                Description = AesTool.Decrypt(AES_Description, UUID);


                if (headdata.Count != 9)
                {
                    ResultPropetries.SetResult(-30);
                    return ResultPropetries;
                }//文件头不长度不吻合

                if (pwdMd5 != headdata[2])
                {
                    ResultPropetries.SetResult(-90);
                    return ResultPropetries;
                }//解锁密码错误

                dstFile = dstFile + Name + SrcType;
                ResultPropetries.SetPropetries(UUID, Name, FriendlyName, int.Parse(Size), SrcType, pwdMd5, srcFile, Description);

                if (File.Exists(dstFile))
                {
                    File.Delete(dstFile);
                }
                using (FileStream fsWrite = new FileStream(dstFile, FileMode.CreateNew))
                {
                    int readCount = 0;
                    byte[] buffer = new byte[FileBuffer + 16];
                    while ((readCount = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        if (readCount != buffer.Length)
                        {
                            byte[] temp = new byte[readCount];
                            Buffer.BlockCopy(buffer, 0, temp, 0, readCount);
                            byte[] debyte = AesTool.Decrypt(temp, fmtPwd);
                            fsWrite.Write(debyte, 0, debyte.Length);
                        }
                        else
                        {
                            byte[] debyte = AesTool.Decrypt(buffer, fmtPwd);
                            fsWrite.Write(debyte, 0, debyte.Length);
                        }
                        progress?.Invoke(sender, new ProgressEventArgs(fsRead.Position, fsRead.Length));
                    }
                }
            }
            string md5 = FileTool.GetMD5(dstFile);
            if (headdata.Count > 1 && md5 == headdata[0])
            {
                ResultPropetries.SetResult((int)Math.Ceiling((DateTime.Now - beginTime).TotalSeconds));//操作成功
            }
            else
            {
                //解密失败后，删除解密的文件
                ResultPropetries.SetResult(-100);//失败
                try { File.Delete(dstFile); }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString(), "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            return ResultPropetries;
        }
    }
    public class Permission
    {
        /// <summary>
        /// 验证授权文件
        /// </summary>
        /// <param name="path">授权文件的路径</param>
        /// <returns>
        /// -1:文件不存在
        /// -2:未知错误
        /// -3:参数个数溢出
        /// -255:验证失败
        /// 0:验证成功
        /// </returns>
        public static int VerifyPermissionFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path, Encoding.Default);
                string content = sr.ReadToEnd();
                string uuid = "";
                string md5 = "0";
                bool pre_result = false;
                try
                {
                    /*
                     * 文件验证：
                     * {UUID}{MD5}
                     * 对前面的UUID进行MD5验证
                     */
                    Regex regex = new Regex("{(.*?)}");
                    MatchCollection mc = regex.Matches(content);  //在内容中匹配与正则表达式匹配的字符
                    int index = 0;
                    foreach (Match m in mc)     //循环匹配到的字符
                    {
                        index++;
                        if (index == 1)
                        {
                            uuid = m.ToString();
                            pre_result = true;
                        }
                        if (index == 2)
                        {
                            md5 = m.ToString();
                            pre_result = true;
                        }
                        if (index > 2)
                        {
                            MessageBox.Show("验证无效", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            pre_result = false;
                            return -3;
                        }
                    }
                    uuid = uuid.Replace("-", "");
                    uuid = uuid.Replace(";", "");
                    uuid = uuid.Replace("{", "");
                    uuid = uuid.Replace("}", "");
                    md5 = md5.Replace("{", "");
                    md5 = md5.Replace("}", "");
                    if (Azylee.Core.DataUtils.EncryptUtils.MD5Tool.Encrypt(uuid).ToString().Equals(md5) && (pre_result == true))
                    {
                        return 0;
                    }
                    else
                    {
                        return -255;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return -2;
                }
            }
            else
            {
                return -1;
            }

        }
        /// <summary>
        /// 创建权限文件
        /// </summary>
        /// <param name="path">创建权限文件的路径</param>
        /// <returns>
        /// -1:文件已存在
        /// -2:未知错误
        /// 0:创建成功
        /// </returns>
        public static int CreatePermissionFile(string path)
        {
            if (File.Exists(path))
            {
                return -1;
            }
            else
            {
                string uuid_string = System.Guid.NewGuid().ToString() + ";" +
                    System.Guid.NewGuid().ToString() + ";" +
                    System.Guid.NewGuid().ToString() + "";
                string attempt_uuid_string = uuid_string.Replace(";", "");
                attempt_uuid_string = attempt_uuid_string.Replace("-", "");

                string md5_string = Azylee.Core.DataUtils.EncryptUtils.MD5Tool.Encrypt(attempt_uuid_string);
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write("{" + uuid_string + "}{" + md5_string + "}");
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    if (VerifyPermissionFile(path) != 0)
                    {

                        MessageBox.Show("内部错误：验证失败", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return -2;
                }
                return 0;
            }
        }
    }

}
