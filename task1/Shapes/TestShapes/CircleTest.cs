using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace TestShapes
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestConstructorNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }

        [TestMethod]
        public void TestConstructorPositive()
        {
            var c = new Circle(2.0);
            Assert.AreEqual(2.0, c.Radius);
        }

        [TestMethod]
        public void TestArea()
        {
            var c = new Circle(2.0);
            Assert.AreEqual(12.5663706144, c.Area, 0.00000001);
        }
    }
}