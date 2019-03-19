using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace WhatsNewWithCSharp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var p1 = NewPoint();
            var p = new Point(0, 0);
            //p1 = p;
        }

        static (int x, int y) NewPoint()
        {
            return (0, 0);
        }
    }
}
