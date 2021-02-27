using Xunit;

namespace arrays
{
    public class TrailingZerosInFactorialTests
    {
        [Theory]
        [InlineData(4, 0)]
        [InlineData(5, 1)]
        [InlineData(10, 2)]
        [InlineData(500, 124)]
        public void Count_ShouldPass(int number, int trailingZerosCount)
        {
            var result = TrailingZerosInFactorial.Count(number);
            Assert.Equal(trailingZerosCount, result);
        }
    }
}