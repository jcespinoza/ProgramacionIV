using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using Tarea1;

namespace Tarea1.Specs
{
    public class WhenMultiplesAre3And5SumBellow10: GivenAMathContext
    {
        private static int result;
        private Because of = () =>
        {
            result = MathInstance.SumMultiples(10, 3, 5);
        };
        private It shouldReturn23 = () => result.ShouldEqual(23);
    }

}
