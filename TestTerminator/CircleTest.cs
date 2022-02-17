using SquareTerminator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestTerminator
{
    public class CircleTest
    {
        [Fact]
        public void TrueCircleSquare()
        {
            var term = new Terminator();
            var array = new double[] { 3 };

            Assert.Equal(28.274333882308138, term.TerminateSquare(array));
        }
    }
}
