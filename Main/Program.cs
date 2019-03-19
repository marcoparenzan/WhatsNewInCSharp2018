using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;

namespace Main
{
    static class Program
    {
        // async Main
        static async Task Main(string[] args)
        {
            // binary literals - 7.2
            // digit separators - 7.2
            int[] values = { 0b0_001, 0b0_010, 0b0_01, 0b0_100, 0b1_000 };
            var result = await SumOfSquaresAsync(values);
            WriteLine(result);
        }

        // default without type(impliated)
        static async Task<int> SumOfSquaresAsync(int[] values, CancellationToken ct = default)
        {
            // 7.3 remove ambiguity
            // 7.2 add naming parameters "unordered", else every one else should be named, for documentation
            return await Task.Run(function: Compute, ct);
            // local functions - 7.0
            // ExpressionBodiedMembers
            int Compute() => values.Select(xx => xx * xx).Sum();
        }

        //unsafe void M<D, E, T>(D d, E e, T* pointer)
        //    where D: Delegate
        //    where E: Enum
        //    where T: unmanaged
        //{
        //    var tuple = (d, Math.PI); // implied names
        //    bool result = tuple == (null, 42); // comparison per element, not important having the same types because because there is a per element equality
        //}
    }
}
