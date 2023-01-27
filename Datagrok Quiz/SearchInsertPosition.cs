using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagrok_Quiz
{
    public class SearchInsertPosition
    {

        public int findIndex(int[] values, int target)
        {

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return i;
                }
                else if (values[i] < target && target < values[i + 1])
                {

                    return i + 1;

                }
                else
                {
                    if (values[values.Length-1]<target)
                    {
                        return values.Length;
                    }
                }

            }

            return 0;

        }

    }
}
