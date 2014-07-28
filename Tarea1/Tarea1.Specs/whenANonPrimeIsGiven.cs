using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenANonPrimeIsGiven: GivenAMathContext
    {
        private static bool result;
        private Because of = () =>
        {
            result = MathInstance.IsPrime(15);
        };

        private It shouldReturnFalse = () =>
        {
            result.ShouldBeFalse();
        };
    }
}