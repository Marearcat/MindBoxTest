using SquareTerminator;
using System;
using Xunit;

namespace TestTerminator
{
    public class TriangleTest
    {
        [Fact]
        public void TrueTriangle()
        {
            var term = new Terminator();
            var array = new double[] { 4, 5, 6 };

            Assert.Equal(121.8605760695394, term.TerminateSquare(array));
        }

        [Fact]
        public void TrueRectangleTriangle()
        {
            var term = new Terminator();
            var array = new double[] { 3, 4, 5 };

            Assert.True(term.IsRectangle(array));
        }

        [Fact]
        public void WrongVergesOfTriangle()
        {
            var term = new Terminator();
            var array = new double[] { 1, 9, 4 };

            Assert.ThrowsAny<ArgumentException>(() => term.TerminateSquare(array));
        }

        [Fact]
        public void WrongRectangleTriangle()
        {
            var term = new Terminator();
            var array = new double[] { 34, 65, 62 };

            Assert.False(term.IsRectangle(array));
        }

        [Fact]
        public void WrongCountOfRectangleParams()
        {
            var term = new Terminator();
            var array = new double[] { 34, 65, 62, 45 };

            Assert.ThrowsAny<ArgumentException>(() => term.IsRectangle(array));
        }

        [Fact]
        public void ZeroCountOfRectangleParams()
        {
            var term = new Terminator();
            var array = new double[] { };

            Assert.ThrowsAny<ArgumentException>(() => term.IsRectangle(array));
        }

        [Fact]
        public void NullOfRectangleArray()
        {
            var term = new Terminator();
            double[] array = null;

            Assert.ThrowsAny<ArgumentException>(() => term.IsRectangle(array));
        }
    }
}
