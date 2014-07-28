using System.Collections.Generic;
using Machine.Specifications;

namespace Tarea1.Specs
{
    public class whenRequestingFactorForZero: GivenAMathContext
    {
        static List<int> resultList ;
        private Because of = () =>
        {
            resultList = MathInstance.GetPrimeFactors(0);
        };

        private It shouldReturnAnEmptyList = () =>
        {
            resultList.ShouldBeEmpty();
        };
    }
}