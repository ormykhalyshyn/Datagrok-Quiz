using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagrok_Quiz
{
    public class rleEncoder
    {

        public string rle(string s)
        {
            if (s == null || s.Length == 0)
            {
                throw new ArgumentException("String must have at least one letter.");
            }

            int counter = 0;
            StringBuilder sb = new StringBuilder();
            char prev = s[0];

            for (var index = 1; index <= s.Length; index++)
            {
                var ch = index == s.Length
                              ? '\0'
                              : s[index];
                counter++;
                if (ch == prev) continue;

                if (!char.IsLetter(prev))
                {
                    throw new ArgumentException("string should contains only letters");
                }
                else
                {
                    sb.Append(prev);
                    sb.Append(counter);
                }
                counter = 0;
                prev = ch;
            }

            return sb.ToString();

        }

    }
}
