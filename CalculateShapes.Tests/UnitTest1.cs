using CalculateShapes;
using NUnit.Framework;

namespace ShapeCalculator
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CircleAreaCalculation()
        {
            var circle = new Circle(5);
            Assert.That(circle.CalculateArea(), Is.EqualTo(78.54).Within(0.01));
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(0.01));
        }

        [Test]
        public void RightAngleTriangleCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRightAngleTriangle(), Is.True);
        }

        [Test]
        public void NonRightAngleTriangleCheck()
        {
            var triangle = new Triangle(2, 3, 4);
            Assert.That(triangle.IsRightAngleTriangle(), Is.False);
        }
    }
}