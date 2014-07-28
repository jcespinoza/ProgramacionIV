using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenRequestionGreatestFactorOf13195: GivenAMathContext
    {
        private static long result;
        private Because of = () =>
        {
            result = MathInstance.GreatestPrimeFactor(13195);
        };

        private It shouldReturn29 = () =>
        {
            result.ShouldEqual(29);
        };
    }
}