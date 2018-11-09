using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginEx
{
    class LoginInfo
        //编号
    {
        private static string _bh;
        public static string Bh
        {
            get { return _bh; }
            set { _bh = value; }
        }
        //权限
        private static string _qx;
        public static string Qx
        {
            get { return _qx; }
            set { _qx = value; }
        }
        //专业编号
        private static string _zybh;
        public static string Zybh
        {
            get { return _zybh; }
            set { _zybh = value; }
        }
        //部门编号
        private static string _bmbh;
        public static string Bmbh
        {
            get { return _bmbh; }
            set { _bmbh = value; }
        }
        //姓名
        private static string _xm;
        public static string Xm
        {
            get { return _xm; }
            set { _xm = value; }
        }

    }
}
