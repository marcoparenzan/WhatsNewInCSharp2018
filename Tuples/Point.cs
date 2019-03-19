using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static System.Console;

namespace WhatsNewWithCSharp
{
    struct Point
    {
        public Point(int x, int y) => (X,Y) = (x >= 0 ? x : throw new ArgumentException("x"), y >= 0 ? y : throw new ArgumentException("y"));

        public int X;
        public int Y;

        public void Deconstruct(out int x, out int y) 
        { 
            x = X; y = Y; 
        }
    }
}
