using Xunit;

namespace arrays
{
    public class ReverseIntegerTests
    {
        [Theory]
        [InlineData(12345, 54321)]
        [InlineData(-321, -123)]
        [InlineData(2147481147, 0)]
        public void Solve_ShouldPass(int input, int expected)
        {
            var result = ReverseInteger.Solve(input);
            Assert.Equal(expected, result);
        }
    }
}