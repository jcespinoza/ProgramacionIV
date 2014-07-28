using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenAPrimeIsProvided: GivenAMathContext
    {
        private static bool result;
        private Because of = () =>
        {
            result = MathInstance.IsPrime(13);
        };

        private It shouldReturnTrue = () =>
        {
            result.ShouldBeTrue();
        };
    }
}