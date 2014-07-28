using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenOneIsNegative:GivenAMathContext
    {
        private Because of = () => {
            result = MathInstance.AreAllPositive(new int[4]{10, -2, 15, 10});
        };

        private It shouldReturnFalse = () => {
            result.ShouldBeFalse();
        };

        private static bool result;
    }
}