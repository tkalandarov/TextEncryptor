using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextEncryptor.Tools
{
    static class ExtensionMethods
    {
        // Removes all leading and trailing white-space characters
        public static string DeleteLeadingAndTrailingSpaces(this string str)
        {
            return str.Trim(' ', '\t');
        }
    }
}
