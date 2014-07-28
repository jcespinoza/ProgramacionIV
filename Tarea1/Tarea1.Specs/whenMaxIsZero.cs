using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenMaxIsZero: GivenAMathContext
    {
        private Because of = () => {
            result = MathInstance.SumMultiples(0, 3, 5);
        };

        private It shouldReturnNegativeOne = () => result.ShouldEqual(-1);

        private static int result;
    }
}