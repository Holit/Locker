﻿//************************************************************************
//      author:     yuzhengyang
//      date:       2017.3.29 - 2017.7.12
//      desc:       网卡信息工具类
//      Copyright (c) yuzhengyang. All rights reserved.
//************************************************************************
using Azylee.Core.DataUtils.CollectionUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace Azylee.Core.WindowsUtils.InfoUtils
{
    public class NetCardInfoTool
    {
        /// <summary>
        /// 获取网卡信息
        /// 【名称、描述、物理地址（Mac）、Ip地址、网关地址】
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, string, string>> GetNetworkCardInfo()
        {
            try
            {
                List<Tuple<string, string, string, string, string>> result = new List<Tuple<string, string, string, string, string>>();
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (var item in adapters)
                {
                    if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet || item.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        string _name = item.Name.Trim();
                        string _desc = item.Description.Trim();
                        string _mac = item.GetPhysicalAddress().ToString();
                        //测试获取数据
                        var x = item.GetIPProperties().UnicastAddresses;
                        string _ip = item.GetIPProperties().UnicastAddresses.Count >= 1 ?
                            item.GetIPProperties().UnicastAddresses[0].Address.ToString() : null;
                        //更新IP为ipv4地址
                        if (item.GetIPProperties().UnicastAddresses.Count > 0)
                            _ip = item.GetIPProperties().UnicastAddresses[item.GetIPProperties().
                                UnicastAddresses.Count - 1].Address.ToString();
                        string _gateway = item.GetIPProperties().GatewayAddresses.Count >= 1 ?
                            item.GetIPProperties().GatewayAddresses[0].Address.ToString() : null;
                        result.Add(new Tuple<string, string, string, string, string>(_name, _desc, _mac, _ip, _gateway));
                    }
                }
                return result;
            }
            catch (NetworkInformationException e)
            {
                return null;
            }
        }
        /// <summary>
        /// 获取网络连接状态
        /// </summary>
        /// <param name="dwFlag"></param>
        /// <param name="dwReserved"></param>
        /// <returns></returns>
        [DllImport("winInet.dll")]
        private static extern bool InternetGetConnectedState(ref int dwFlag, int dwReserved);
        /// <summary>
        /// 获取网络连接状态
        /// </summary>
        /// <returns></returns>
        public static bool LocalConnectionStatus()
        {
            try
            {
                int INTERNET_CONNECTION_MODEM = 1;
                int INTERNET_CONNECTION_LAN = 2;

                int dwFlag = 0;
                if (InternetGetConnectedState(ref dwFlag, 0)) return true;
            }
            catch { }
            return false;
        }
        /// <summary>
        /// 获取网络连接操作状态
        /// </summary>
        /// <param name="mac"></param>
        /// <returns></returns>
        public static OperationalStatus GetOpStatus(string mac)
        {
            try
            {
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (var item in adapters)
                {
                    string _mac = item.GetPhysicalAddress().ToString();
                    if(_mac.ToUpper() == mac.ToUpper())
                        return item.OperationalStatus;
                }
            }
            catch { }
            return OperationalStatus.Unknown;
        }
        /// <summary>
        /// 获取网卡实例名称
        /// </summary>
        /// <returns></returns>
        public static string[] GetInstanceNames()
        {
            string[] instances = null;
            try
            {
                PerformanceCounterCategory performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
                instances = performanceCounterCategory.GetInstanceNames();
            }
            catch { }
            return instances;
        }

        /// <summary>
        /// 获取本机IPv4的IP地址
        /// </summary>
        /// <returns></returns>
        public static List<IPAddress> GetIPv4Address()
        {
            List<IPAddress> hosts = new List<IPAddress>();
            try
            {
                var temp = Dns.GetHostAddresses(Dns.GetHostName());
                if (ListTool.HasElements(temp))
                {
                    foreach (var t in temp)
                    {
                        if (t.AddressFamily == AddressFamily.InterNetwork)
                        {
                            hosts.Add(t);
                        }
                    }
                }
            }
            catch (Exception e) { }
            return hosts;
        }
        /// <summary>
        /// 获取本机IPv4的IP地址
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllIPv4Address()
        {
            List<string> hosts = new List<string>();
            try
            {
                var temp = Dns.GetHostAddresses(Dns.GetHostName());
                if (ListTool.HasElements(temp))
                {
                    foreach (var t in temp)
                    {
                        if (t.AddressFamily == AddressFamily.InterNetwork)
                        {
                            hosts.Add(t.ToString());
                        }
                    }
                }
            }
            catch (Exception e) { }
            hosts.Add("0.0.0.0");
            hosts.Add("127.0.0.1");
            return hosts;
        }

        /// <summary>
        /// 全小写MAC地址
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ShortMac(string s)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                return s.Replace("-", "").Replace(":", "").ToLower();
            }
            return "";
        }
        /// <summary>
        /// 格式化MAC地址（大写、':' 分割）
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string MACFormat(string s, bool isUpper = true)
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(s))
            {
                if (s.Length == 12)
                {
                    sb.Append(
                         $"{s.Substring(0, 2)}:" +
                         $"{s.Substring(2, 2)}:" +
                         $"{s.Substring(4, 2)}:" +
                         $"{s.Substring(6, 2)}:" +
                         $"{s.Substring(8, 2)}:" +
                         $"{s.Substring(10, 2)}");
                }
            }
            return isUpper ? sb.ToString().ToUpper() : sb.ToString().ToLower();
        }
    }
}
