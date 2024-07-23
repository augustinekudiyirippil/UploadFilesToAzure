using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToCopyFiles
{
    public static class StringExtension
    {
     

        public static string[]  xSplit(string str, string sep)
        {
            return str.Split(new[] { sep }, StringSplitOptions.None);
        }
    }
}
