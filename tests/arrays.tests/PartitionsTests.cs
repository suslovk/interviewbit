using System.Linq;
using Xunit;

namespace arrays
{
    public class PartitionsTests
    {
        [Theory]
        [InlineData(2, 1, 2, 3, 0, 3)]
        [InlineData(1, 0, 1, -1, 0)]
        [InlineData(4, 1, 2, 0, 3, 0, 3)]
        public void GetSplitsCount_ShouldPass(int expectedSplitsCount, params int[] arr)
        {
            var actualSplitsCount = Partitions.GetSplitsCount(arr.Length, arr.ToList());
            Assert.Equal(expectedSplitsCount, actualSplitsCount);
        }
    }
}