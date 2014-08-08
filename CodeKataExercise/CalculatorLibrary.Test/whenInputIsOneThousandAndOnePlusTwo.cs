using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenInputIsOneThousandAndOnePlusTwo:GivenACalculatorContext
    {
        private Because of = () =>
        {
            functionResult = strCalc.Add("//+\n2+1001");
        };

        private It shouldIgnoreNumbersBiggerThan1000 = () =>
        {
            functionResult.ShouldEqual(2);
        };
    }

    public class whenCustomDelimiterIsOfLenghtGreaterThanOneChar: GivenACalculatorContext
    {
        private Because of = () =>
        {
            functionResult = strCalc.Add("//")
        };

        private It shouldReturnTheirSum = () =>
        {
        };
    }
}