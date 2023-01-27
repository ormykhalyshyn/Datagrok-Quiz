using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagrok_Quiz
{
    public class Palindrom
    {
        public bool isPalindromable(string s)
        {

            List<char> list = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i]))
                    list.Remove((char)s[i]);
                else
                    list.Add(s[i]);
            }


            if (s.Length % 2 == 0 && list.Count == 0
                ||
                (s.Length % 2 == 1
                 && list.Count == 1))
                return true;

            else
                return false;

        }

    }
}
