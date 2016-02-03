using CTMTDDPractice.Shapes;
using NUnit.Framework;

namespace Shapes.Tests
{
    class CircleTests
    {
        [TestCase(5, 31.42)]
        [TestCase(10, 62.83)]
        public void Should_ReturnCircumferenceOfACircle(int radius, double expectedResult)
        {
            //Arrange

            var circle = new Circle(radius);
            //Act


            var result = circle.Circumference();
            //Assert

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(10,314.16)]
        [TestCase(7,153.94)]
        public void Should_ReturnAreaOfACircle(int radius, double expectedResult)
        {
            //Arrange
            
            var circle = new Circle(radius);
            //Act

            
            var result = circle.Area();
            //Assert

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }

    
}
