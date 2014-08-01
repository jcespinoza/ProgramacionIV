using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int sumToReturn = 0;
            if (string.IsNullOrEmpty(numbers))
                return 0;

            foreach (string value in numbers.Split(','))
            {
                sumToReturn += Convert.ToInt32(value);
            }
                
            return sumToReturn;
        }
    }
}
