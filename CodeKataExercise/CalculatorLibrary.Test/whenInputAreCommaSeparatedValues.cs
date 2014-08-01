using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenInputAreCommaSeparatedValues: GivenACalculatorContext
    {
        private Because of = () =>
        {
            functionResult = strCalc.Add("45, 78, 98");
        };

        private It shouldReturnTheirSum = () =>
        {
            functionResult.ShouldEqual(45 + 78 + 98);
        };
    }

    public class whenValuesAreNewLineSeparated: GivenACalculatorContext
    {
        
        private Because of = () =>
        {
            functionResult = strCalc.Add("45, 98\n58");
        };

        private It shouldReturnTheirSum = () =>
        {
            functionResult.ShouldEqual(45 + 98 + 58);
        };
    }
}