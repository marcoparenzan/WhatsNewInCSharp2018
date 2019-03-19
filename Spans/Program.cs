using System;

using static System.Console;

namespace WhatsNewWithCSharp
{
    static class Program
    {
        //public static Span<int> fieldspan;

        static void Main(string[] args)
        {
            // Array ==> garbage collected
            Span<int> span = stackalloc int[10]; // 7.2
            
            //int[] array = new int[10];
            // ReadOnlySpan
            //Span<int> span = array.AsSpan();
            //Span<int> slice = span.Slice(3, 5);
            //for (int i = 0; i < 10; i++) array[i] = i;
            for (int i = 0; i < 10; i++) span[i] = i; // goto definition...it's a ref
            foreach (var v in span[3..^1]) WriteLine(v);
            //foreach (var v in span) WriteLine(v);

            var index = 1..4;

            ReadLine();

            var t = "<text to parse>".AsSpan().Slice(2,3);
        }
    }
}
