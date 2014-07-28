using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarea1
{
    public class MathChallenge
    {
        public int SumMultiples(int max, params int[] multiples)
        {
            int totalSum = 0;
            
            if (multiples.Count() < 1 || max <= 0 || !AreAllPositive(multiples))
                return -1;

            for (int natularNumber = 1; natularNumber < max; natularNumber++)
            {
                foreach(int multiple in multiples)
                {
                    if(IsDivisibleBy(multiple, natularNumber))
                        totalSum += natularNumber;
                }
            }
            return totalSum;
        }

        public bool AreAllPositive(params int[] values)
        {
            foreach (int value in values)
                if (value <= 0)
                    return false;
            return true;
        }

        public long GreatestPrimeFactor(long number)
        {
            int factor = GetPrimeFactors(number).LastOrDefault();
            return (factor == 0)? number: factor;
        }

        public List<int> GetPrimeFactors(long number)
        {
            if (number <= 0)
                return new List<int>();
            if (number >= 1 && number <= 3)
                return new List<int>(){1};

            List<int> factors = new List<int>(){1};
            if(IsDivisibleBy(2, number))
                factors.Add(2);
            for (int i = 3; i < number; i += 2)
            {
                if (IsPrime(i) && IsDivisibleBy(i, number))
                    factors.Add(i);
            }
            return factors;
        }

        public bool IsDivisibleBy(int multiple, long testSubject)
        {
            if (multiple == 0)
                return false;
            return testSubject%multiple == 0;
        }

        public bool IsPrime(long number)
        {
            if (number < 0 || IsDivisibleBy(2, number)) return false;

            if (number > 0 && number <= 3)
                return true;
            for (int i = 3; i < number; i += 2)
            {
                if (IsDivisibleBy(i, number))
                    return false;
            }
            return true;
        }
    }
}
