using Xunit;

namespace arrays
{
    public class PowerOfTwoIntsTests
    {
        [Theory]
        [InlineData(4, true)]
        [InlineData(1024000000, true)]
        public void Solve_ShouldPass(int number, bool expectedResult)
        {
            var result = PowerOfTwoInts.Solve(number);
            Assert.Equal(expectedResult, result);
        }
    }
}