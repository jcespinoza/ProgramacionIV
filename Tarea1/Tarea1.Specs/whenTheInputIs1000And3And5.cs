using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenTheInputIs1000And3And5: GivenAMathContext
    {
        private static int result;
        private Because of = () => {
            result = MathInstance.SumMultiples(1000, 3, 5);
        };

        private It shouldReturnTheRightAnswer = () => {
            result.ShouldBeGreaterThanOrEqualTo(233168);
        };
    }
}