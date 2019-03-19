using System;

using static System.Console;

namespace WhatsNewWithCSharp
{
    // the refs always
    // the out always, refs that are mandatory to set

    // 1. add ref
    // big structures, ref is better

    static class Program
    {
        // this ref 7.2 ... refactor
        // ref readonly: don't break the promise, because you return a 
        // variable selection, passing the specific variable
        static ref int OrMaybe(this ref int x, ref int y) // add ref, add this, add in
        {
            x++; // y--; // readonly variable y because of in
            return ref y;
        }
   
        // 7.0 ref function every where
        static void Main(string[] args)
        {
            int a = 1, b = 10;
            ref int c = ref a.OrMaybe(ref b); // in decorator, optinal
            //int cc = a.OrMaybe(1); // internally a var is created
            c += 100;

            // reassignation
            // refactor ==> 7.3
            // mutate a

            WriteLine($"a={a},b={b},c={c}");

            ReadLine();
        }
    }
}
