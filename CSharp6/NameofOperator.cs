using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public static class NameofOperator
    {
        public static string Append(this string str, string appendString)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (appendString == null)
            {
                throw new ArgumentNullException(nameof(appendString));
            }

            str = string.Concat(str, appendString);

            return str;
        }
    }
}
