using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenMoreThanTwoMultiplesAreProvided: GivenAMathContext
    {
        private static int result;
        private Because of = () => {
            result = MathInstance.SumMultiples(100, new int[]{3, 2, 5});
        };

        private It shouldGiveTheRightAnswerIt = () => {
            result.ShouldNotEqual(-1);
        };
    }
}