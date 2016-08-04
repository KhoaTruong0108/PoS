using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lhk.POS.Core.Util
{
    public class StringUtil
    {
        public static string ToEmpty(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            return value.ToString();
        }

        public static int ToInt(string value)
        {
            int temp;
            if (value == null || int.TryParse(value, out temp) == false)
            {
                return -1;
            }
            return temp;
        }
    }
}
