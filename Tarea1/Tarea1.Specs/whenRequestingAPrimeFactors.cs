using System.Collections.Generic;
using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenRequestingAPrimeFactors: GivenAMathContext
    {
        private static List<int> resultList;
        private Because of = () =>
        {
            resultList = MathInstance.GetPrimeFactors(31);
        };

        private It shouldReturnASingleElementList = () =>
        {
            resultList.ShouldContainOnly(1);
        };
    }
}