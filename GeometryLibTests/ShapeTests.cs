using System;
using GeometryLib.Factories;
using GeometryLib.Models;
using NUnit.Framework;

namespace GeometryLibTests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25));
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(6));
            
        }

        [Test]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRightTriangle());
        }

        [Test]
        public void NonRightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.That(triangle.IsRightTriangle());
        }

        [Test]
        public void ShapeFactoryCircleTest()
        {
            var shape = ShapeFactory.CreateCircle(5);
            Assert.That(shape, Is.InstanceOf<Circle>());
            Assert.That(shape.CalculateArea(), Is.EqualTo(Math.PI * 25));
        }

        [Test]
        public void ShapeFactoryTriangleTest()
        {
            var shape = ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.That(shape, Is.InstanceOf<Triangle>());
            Assert.That(shape.CalculateArea(), Is.EqualTo(6));
        }
    }
}
