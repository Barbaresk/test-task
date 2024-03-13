using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace TestShapes
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestConstructorNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 1, 1));
        }

        [TestMethod]
        public void TestConstructorPositive()
        {
            var t = new Triangle(2, 3, 4);
            Assert.AreEqual(2.0, t.Sides.ElementAt(0));
            Assert.AreEqual(3.0, t.Sides.ElementAt(1));
            Assert.AreEqual(4.0, t.Sides.ElementAt(2));
        }

        [TestMethod]
        public void TestArea()
        {
            var t = new Triangle(2, 3, 4);
            Assert.AreEqual(2.904738, t.Area, 0.000001);
        }

        [TestMethod]
        public void TestIsRight()
        {
            var t = new Triangle(3, 4, 5);
            Assert.IsTrue(t.IsRight);

            t = new Triangle(3, 5, 4);
            Assert.IsTrue(t.IsRight);

            t = new Triangle(4, 3, 5);
            Assert.IsTrue(t.IsRight);

            t = new Triangle(4, 5, 3);
            Assert.IsTrue(t.IsRight);

            t = new Triangle(5, 3, 4);
            Assert.IsTrue(t.IsRight);

            t = new Triangle(5, 4, 3);
            Assert.IsTrue(t.IsRight);

            t = new Triangle(4, 4, 5);
            Assert.IsFalse(t.IsRight);
        }
    }
}