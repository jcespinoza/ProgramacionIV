using System;
using System.Linq;

namespace Tarea1
{
    public class MathChallenge
    {
        public int SumMultiples(int max, params int[] multiples)
        {
            int sum = 0;
            Console.Write(multiples);
            if (multiples.Count() < 1 || max <= 0 || !AreAllPositive(multiples))
                return -1;

            for (int i = 1; i < max; i++)
            {
                if (IsDivisibleBy(multiples[0], i) || (IsDivisibleBy(multiples[1], i)))
                    sum += i;
            }
            return sum;
        }

        public bool AreAllPositive(int[] values)
        {
            foreach (int value in values)
                if (value <= 0)
                    return false;
            return true;
        }

        public bool IsDivisibleBy(int multiple, int testSubject)
        {
            if (multiple == 0)
                return false;
            return testSubject%multiple == 0;
        }
    }
}
