using System.Linq;
using Xunit;

namespace arrays
{
    public class PerfectPeakOfArrayTests
    {
        [Theory]
        [InlineData(5, 1, 4, 3, 6, 8, 10, 7, 9)]
        [InlineData(18, 13, 7, 19, 24, 4, 11, 19, 16, 12, 25, 32, 26)]
        public void PeakExists_Returns1(params int[] arr)
        {
            var peakExists = PerfectPeakOfArray.PeakExists(arr.ToList());
            Assert.Equal(1, peakExists);
            Assert.Equal(1, peakExists);
        }
        
        [Theory]
        [InlineData(5, 1, 4, 4)]
        [InlineData(5, 26, 24, 29, 16, 25, 28, 18, 9, 2, 1, 11, 23, 19, 15, 6)]
        [InlineData(10, 15, 24, 1, 16, 14, 19)]
        public void PeakExists_Returns0(params int[] arr)
        {
            var peakExists = PerfectPeakOfArray.PeakExists(arr.ToList());
            Assert.Equal(0, peakExists);
            Assert.Equal(0, peakExists);
        }
    }
}
