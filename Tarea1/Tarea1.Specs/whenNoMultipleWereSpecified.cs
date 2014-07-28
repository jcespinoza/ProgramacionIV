using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenNoMultipleWereSpecified: GivenAMathContext
    {
        static int result;
        private Because of = () => {
            result = MathInstance.SumMultiples(10);
        };

        private It shouldReturnNegativeOneIt = () => {
            result.ShouldEqual(-1);
        };
    }
}