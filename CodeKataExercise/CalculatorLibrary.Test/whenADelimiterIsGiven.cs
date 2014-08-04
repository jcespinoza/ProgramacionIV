using System;
using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenADelimiterIsGiven: GivenACalculatorContext
    {
        
        private Because of = () =>
        {
            functionResult = strCalc.Add("//;\n4;5;9");
        };

        private It shouldReturnTheirSum = () => functionResult.ShouldEqual(4 + 5 + 9);
    }
}