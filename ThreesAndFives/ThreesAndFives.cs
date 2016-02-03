using NUnit.Framework;

namespace ThreesAndFives
{
    class ThreesAndFives
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        //Find the sum of all the multiples of 3 or 5 below 1000.
        [Test]
        public void Should_ReturnSumOf23_WhenMultipleOf3And5Below10AreSummed()
        {
            //Arrange
            var multiplesSum = new MultipleSum();
            const int limit = 10;
            //Act

            
            var result = multiplesSum.Sum(limit);
            //Assert

            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void Should_ReturnSumOf78_WhenMultipleOf3And5Below20AreSummed()
        {
            //Arrange
            var multiplesSum = new MultipleSum();
            const int limit = 1000;
            //Act

            
            var result = multiplesSum.Sum(limit);
            //Assert

            Assert.That(result, Is.EqualTo(78));
        }
    }

    internal class MultipleSum
    {
        public int Sum(int limit)
        {
            int total=0;
            for (int i = 0; i < limit; i++)
            {
                if ((i%3 == 0) || (i%5 == 0))
                {
                    total += i;
                }

            }
            return total;

        }
    }
}
