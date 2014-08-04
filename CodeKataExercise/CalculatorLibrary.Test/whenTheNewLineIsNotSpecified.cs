using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenTheNewLineIsNotSpecified: GivenACalculatorContext
    {
        private Because of = () =>
        {
            functionResult = strCalc.Add("//;4;5;9");
        };

        private It shouldReturnZero = () => functionResult.ShouldEqual(0);
    }
}