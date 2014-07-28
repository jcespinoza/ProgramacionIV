using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenANegativeIsCheckedTobePalindromic: GivenAMathContext
    {
        static bool result;
        private Because of = () =>
        {
            result = MathInstance.IsPalindromic(-5);
        };

        private It shouldReturnFalse = () =>
        {
            result.ShouldBeFalse();
        };
    }
}