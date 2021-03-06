﻿using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class WhenInputIsASingleNonZeroDigit: GivenACalculatorContext
    {
        private static int input = 9;
        private Because of = () =>
        {
            functionResult = strCalc.Add(input.ToString());
        };

        private It shouldReturnTheDigit = () =>
        {
            functionResult.ShouldEqual(input);
        };
    }
}