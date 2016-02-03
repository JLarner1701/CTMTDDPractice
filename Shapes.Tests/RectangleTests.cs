using CTMTDDPractice.Shapes;
using NUnit.Framework;

namespace Shapes.Tests
{
    [TestFixture]
    class RectangleTests
    {
        //Calculate perimeter of rectangle
        [Test]
        public void Should_ReturnAreaOf12_When_ARectangleHasALengthOf6AndAWidthOf2()
        {
            //Arrange
            int length = 6;
            int width = 2;
            var rectangle=new Rectangle(length,width);
            //Act

            var result = rectangle.Area();
            //Assert

            Assert.That(result, Is.EqualTo(12));
        }


        [Test]
        public void Should_ReturnPerimeterOf16_When_ARectangleHasALengthOf6AndAWidthOf2()
        {
            //Arrange
            var length = 6;
            var width = 2;
            var rectangle = new Rectangle(length, width);

            //Act
            var result = rectangle.Perimeter();

            //Assert

            Assert.That(result, Is.EqualTo(16));
        }
    }
}
