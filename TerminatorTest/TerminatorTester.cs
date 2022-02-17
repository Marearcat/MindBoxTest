using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareTerminator;

namespace TerminatorTest
{
    [TestClass]
    public class TerminatorTester
    {
        [TestMethod]
        public void RectangleTriangle()
        {
            //Arrange
            var term = new Terminator();
            var array = new double[] { 3, 4, 5 };

            Assert.AreEqual(77.76888838089432, term.TerminateSquare(array));
        }
    }
}
