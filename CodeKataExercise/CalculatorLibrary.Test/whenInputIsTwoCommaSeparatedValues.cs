using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenInputIsTwoCommaSeparatedValues:GivenACalculatorContext
    {
        
        private Because of = () =>
        {
            functionResult = strCalc.Add("45,50");
        };

        private It shouldReturnTheirSum = () =>
        {
            functionResult.ShouldEqual(45 + 50);
        };
    }
}