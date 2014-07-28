using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenMultipleIsZero: GivenAMathContext
    {
        private static bool result;
        private Because of = () => {
            result = MathInstance.IsDivisibleBy(0, 15);
        };

        private It shouldReturnFalseIt = () => {
            result.ShouldBeFalse();
        };
    }
}