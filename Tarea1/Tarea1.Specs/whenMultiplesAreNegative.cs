using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenMultiplesAreNegative:GivenAMathContext
    {
        private static int result;
        private Because of = () => {
            result = MathInstance.SumMultiples(10, -5, 3);
        };

        private It shouldReturnNegativeOneIt = () => result.ShouldEqual(-1);
    }
}