using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenCheckingANonPalindromic: GivenAMathContext
    {
        private static bool result;
        private Because of = () =>
        {
            result = MathInstance.IsPalindromic(5432);
        };

        private It shouldReturnFalse = () =>
        {
            result.ShouldBeFalse();
        };
    }
}