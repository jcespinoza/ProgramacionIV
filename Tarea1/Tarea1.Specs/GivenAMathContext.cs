using Machine.Specifications;

namespace Tarea1.Specs
{
    public class GivenAMathContext
    {
        public static MathChallenge MathInstance;
        private Establish context = () =>
        {
            MathInstance = new MathChallenge();
        };
    }
}