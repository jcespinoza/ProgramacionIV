using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class GivenACalculatorContext
    {
        public static StringCalculator strCalc;
        Establish context = () =>
        {
            strCalc = new StringCalculator();
        };
    }
}
