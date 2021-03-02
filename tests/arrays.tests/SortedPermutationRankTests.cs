using Xunit;

namespace arrays
{
    public class SortedPermutationRankTests
    {
        [Theory]
        [InlineData("acb", 2)]
        [InlineData("string", 598)]
        public void Solve_ShouldPass(string input, int expectedRank)
        {
            var result = SortedPermutationRank.Solve(input);
            Assert.Equal(expectedRank, result);
        }
    }
}