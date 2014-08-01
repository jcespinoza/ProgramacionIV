using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenInputIsASingleInteger: GivenACalculatorContext
    {
        private static int input = 98;
        private Because of = () =>
        {
            functionResult = strCalc.Add(input.ToString());
        };

        private It shouldReturnTheInput = () =>
        {
            functionResult.ShouldEqual(input);
        };
    }
}