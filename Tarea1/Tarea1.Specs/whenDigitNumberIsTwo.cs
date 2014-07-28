using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenDigitNumberIsTwo: GivenAMathContext
    {
        static long result;
        private Because of = () =>
        {
            result = MathInstance.LargestPalindromeProductOfTwoNumbers(2);
        };

        private It shouldReturn9009 = () =>
        {
            result.ShouldEqual(9009);
        };
    }
}