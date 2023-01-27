using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagrok_Quiz
{
    public class Duplicate
    {
        public int findDuplicate(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] == values[j])
                        return values[i];
                }
            }
            return -1;
        }
    }
}
