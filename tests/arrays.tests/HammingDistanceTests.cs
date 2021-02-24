using System.Linq;
using Xunit;

namespace arrays
{
    public class HammingDistanceTests
    {
        [Theory]
        [InlineData(8, 2, 4, 6)]
        [InlineData(104, 96, 96, 7, 81, 2, 13)]
        [InlineData(308, 16, 0, 1, 0, 0, 16, 0, 0, 0, 0, 9, 4, 0, 0, 0, 0, 0, 0, 2, 8, 0)]
        public void Calculate_ShouldPass(int expected, params int[] arr)
        {
            var result = HammingDistance.Calculate(arr.ToList());
            Assert.Equal(expected, result);
        }
    }
}