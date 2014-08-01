﻿using Machine.Specifications;

namespace CalculatorLibrary.Test
{
    public class whenInputIsEmptyString: GivenACalculatorContext
    {
        private Because of = () =>
        {
            functionResult = strCalc.Sum("");
        };

        private It shouldReturnZero = () =>
        {
            functionResult.ShouldEqual(0);
        };
    }
}