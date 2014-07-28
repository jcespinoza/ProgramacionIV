using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenAllArePositive: GivenAMathContext
    {
        private Because of = () => {
                                       result = MathInstance.AreAllPositive(new int[4] { 10, 8, 15, 10 });
        };

        private It shouldReturnTrueIt = () => {
                                                  result.ShouldBeTrue();
        };
        private static bool result;
    }
}