using System;
using System.Collections.Generic;
using System.Text;

namespace SquareTerminator
{
    public class Terminator
    {
        public double TerminateSquare(double[] measures)
        {
            if (measures == null) { throw new ArgumentNullException(); }
            if (measures.Length == 0) { throw new ArgumentException("Array is empty"); }

            if (measures.Length == 1)
            {
                return Math.PI * measures[0] * measures[0];
            }
            else if (measures.Length == 3)
            {
                if(IsParamsWrong(measures[0], measures[1], measures[2]))
                {
                    throw new ArgumentException("Wrong params.");
                }

                double perimeter = measures[0] + measures[1] + measures[2];
                return Math.Sqrt(perimeter * (perimeter - measures[0]) * (perimeter - measures[1]) * (perimeter - measures[2]));
            }

            throw new ArgumentException("Wrong count of params.");
        }

        bool IsParamsWrong(double param1, double param2, double param3)
        {
            if (param1 <= 0 || param2 <= 0 || param3 <= 0 || param1 + param2 <= param3 || param1 + param3 <= param2 || param2 + param3 <= param1)
            {
                return true;
            }

            return false;
        }

        public bool IsRectangle(double[] measures)
        {
            if (measures == null) { throw new ArgumentNullException(); }
            if (measures.Length == 0) { throw new ArgumentException("Array is empty"); }

            if (measures.Length == 3)
            {
                if (IsParamsWrong(measures[0], measures[1], measures[2]))
                {
                    throw new ArgumentException("Wrong params.");
                }

                if (measures[0] * measures[0] + measures[1] * measures[1] == measures[2] * measures[2])
                {
                    return true;
                }

                return false;
            }

            throw new ArgumentException("Wrong count of params.");
        }
    }
}
