using System;
using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenANegativeIsGivenInParametersNoCustomDelimiter: GivenACalculatorContext
    {
        private static Exception exception;
        private Because of = () =>
        {
            exception = Catch.Exception(() => strCalc.Add("45,8,-7"));
        };

        private It shouldThrowException = () =>
        {
            exception.ShouldNotBeNull();
        };
    }
}