using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagrok_Quiz
{
    public class Intersection
    {

        public void intersectionCount(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);

            int i = 0, j = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    i++;
                else if (b[j] < a[i])
                    j++;
                else
                {
                    Console.Write(b[j++] + " ");
                    i++;
                }
            }
        }

    }
}
