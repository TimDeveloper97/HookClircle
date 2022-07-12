using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookCircleWD
{
    public static class ExtendedHelper
    {
        public static string ExtendedToString(this List<Keys> keys)
        {
            string s = "";
            foreach (var item in keys)
            {
                s += item + " + ";
            }
            return s.Length < 3 ? null : s.Substring(0, s.Length - 3);
        }
    }
}
