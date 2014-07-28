using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenMaxIsNegative:GivenAMathContext
    {
        private Because of = () =>
        {
            result = MathInstance.SumMultiples(-5, 3, 5);
        };

        private It shouldReturnNegativeOne = () => result.ShouldEqual(-1);
        private static int result;
    }
}