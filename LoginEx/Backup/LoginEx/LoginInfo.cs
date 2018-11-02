using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginEx
{
    class LoginInfo
    {
        private static string _bh;
        public static string Bh
        {
            get { return _bh; }
            set { _bh = value; }
        }
    }
}
