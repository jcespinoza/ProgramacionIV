using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenAskingIfANegativeIsPrime: GivenAMathContext
    {
        static bool result;
        private Because of = () =>
        {
            result = MathInstance.IsPrime(-5);
        };

        private It shouldReturnFalse = () =>
        {
            result.ShouldBeFalse();
        };
    }
}