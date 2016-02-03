using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Shapes.Tests
{
    class CircleTests
    {
        [TestCase(5, 31.42)]
        [TestCase(10, 62.83)]
        public void Should_ReturnCircumferenceOf31Point4_WhenACircleHasARadiusOf5(int radius, double expectedResult)
        {
            //Arrange
           
            var circle = new Circle(radius);
            //Act

            
            var result = circle.Circumference();
            //Assert

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }

    internal class Circle
    {
        private readonly int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public double Circumference()
        {
            return Math.Round(2*Math.PI*_radius,2);
        }
    }
}
