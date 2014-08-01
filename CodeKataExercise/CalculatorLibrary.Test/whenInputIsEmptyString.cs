using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenInputIsEmptyString: GivenACalculatorContext
    {
        private static int result;
        private Because of = () =>
        {
            result = strCalc.Sum("");
        };

        private It shouldReturnZero = () =>
        {
            result.ShouldEqual(0);
        };
    }
}