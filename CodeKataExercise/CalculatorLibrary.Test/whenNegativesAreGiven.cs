using System;
using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenNegativesAreGiven: GivenACalculatorContext
    {
        private static Exception exception;
        private Because of = () =>
        {
            exception =Catch.Exception(() => strCalc.Add("45,8,-7,-8"));
        };

        private It shouldThrowExceptionWithNegativesInMessage = () =>
        {
            exception.ShouldNotBeNull();
            exception.Message.ShouldContain("Negatives not allowed", "-7", "-8");
        };
    }
}