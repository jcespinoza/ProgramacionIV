using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StringCalculator
    {
        public int Sum(string param)
        {
            if (param != "0")
                return Int32.Parse(param);
            return 0;
        }
    }
}
