using System;
using SquareTerminator;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            var term = new Terminator();
            var array = new double[] { 3, 4, 5 };

            Console.WriteLine("a = " + array[0] + ", b = " + array[1] + ", c = " + array[2] + 
                "\nSquare = " + term.TerminateSquare(array) + 
                "\n-Is rectangle?\n-" + term.IsRectangle(array) + "\n");

            array[0] = 6;
            Console.WriteLine("a = " + array[0] + ", b = " + array[1] + ", c = " + array[2] +
                "\nSquare = " + term.TerminateSquare(array) +
                "\n-Is rectangle?\n-" + term.IsRectangle(array) + "\n");

            array = new double[] { 3 };
            Console.WriteLine("r = " + array[0] +
                "\nSquare = " + term.TerminateSquare(array));
        }
    }
}
