using Xunit;

namespace arrays
{
    public class GreatestCommonDivisorTests
    {
        [Theory]
        [InlineData(6, 9, 3)]
        public void Get_ShouldPass(int first, int second, int expected)
        {
            var result = GreatestCommonDivisor.Get(first, second);
            Assert.Equal(expected, result);
        }
    }
}