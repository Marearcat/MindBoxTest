using SquareTerminator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestTerminator
{
    public class ArgumentTest
    {
        [Fact]
        public void WrongCountOfParams()
        {
            var term = new Terminator();
            var array = new double[] { 34, 65, 62, 45 };

            Assert.ThrowsAny<ArgumentException>(() => term.TerminateSquare(array));
        }

        [Fact]
        public void ZeroCountOfParams()
        {
            var term = new Terminator();
            var array = new double[] { };

            Assert.ThrowsAny<ArgumentException>(() => term.TerminateSquare(array));
        }

        [Fact]
        public void NullOfParams()
        {
            var term = new Terminator();
            double[] array = null;

            Assert.ThrowsAny<ArgumentException>(() => term.TerminateSquare(array));
        }
    }
}
