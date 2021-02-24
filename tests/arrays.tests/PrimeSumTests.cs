using Xunit;

namespace arrays
{
    public class PrimeSumTests
    {
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(144, 5, 139)]
        public void Calculate_ShouldPass(int sum, params int [] expected)
        {
            var result = PrimeSum.Calculate(sum);
            Assert.Equal(expected, result);
        }
    }
}