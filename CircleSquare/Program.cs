using CircleSquare.Core;
using System;
using System.Collections.Generic;

namespace CircleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle(3, 0, 6);
            Console.WriteLine(t.CalculateSquare());
        }
    }
}
