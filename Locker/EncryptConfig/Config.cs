using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locker.EncryptConfig
{
    class Go
    {
        private float _TieMu = 5.5f;
        private string _Rule = "数子法";
        [CategoryAttribute("规则"), DescriptionAttribute("贴目")]
        public float TieMu
        {
            get { return _TieMu; }
            set { _TieMu = TieMu; }
        }
        [CategoryAttribute("规则"), DescriptionAttribute("计算法")]
        public string Rule
        {
            get { return _Rule; }
            set { _Rule = Rule; }
        }

        private int _Black = 0;
        private int _White = 0;
        [CategoryAttribute("围棋"), DescriptionAttribute("黑")]
        public int Black
        {
            get { return _Black; }
            set { _Black = Black; }
        }
        [CategoryAttribute("围棋"), DescriptionAttribute("白")]
        public int White
        {
            get { return _White; }
            set { _White = White; }
        }
    }

}
