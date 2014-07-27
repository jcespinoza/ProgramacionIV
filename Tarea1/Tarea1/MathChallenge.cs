using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class MathChallenge
    {
        public int SumMultiples(int max, params int[] multiples)
        {
            int sum = 0;
            if (multiples.Count() < 1)
                return -1;
            else
            {
                for (int i = 0; i < max; i++)
                {
                    if ((i%multiples[0] == 0) || (i%multiples[1] == 0))
                        sum += i;
                }
            }
            return sum;
        }

        
    }
}
