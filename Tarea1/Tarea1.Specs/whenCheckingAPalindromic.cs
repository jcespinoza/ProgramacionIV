using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenCheckingAPalindromic: GivenAMathContext
    {
        static bool result ;
        private Because of = () =>
        {
            result = MathInstance.IsPalindromic(202);
        };

        private It shouldReturnTrue = () =>
        {
            result.ShouldBeTrue();
        };
    }
}