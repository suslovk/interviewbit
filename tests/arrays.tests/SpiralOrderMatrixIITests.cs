using System.Linq;
using Xunit;

namespace arrays
{
    // ReSharper disable once InconsistentNaming
    public class SpiralOrderMatrixIITests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "1,2;4,3")]
        [InlineData(3, "1,2,3;8,9,4;7,6,5")]
        [InlineData(4, "1,2,3,4;12,13,14,5;11,16,15,6;10,9,8,7")]
        [InlineData(5, "1,2,3,4,5;16,17,18,19,6;15,24,25,20,7;14,23,22,21,8;13,12,11,10,9")]
        public void Generate_ShouldReturnValidMatrix(int dimensions, string expected)
        {
            var result = SpiralOrderMatrixII.Generate(dimensions);
            var actual = string.Join(';', result.Select(row => string.Join(',', row)));
            Assert.Equal(expected, actual);
        }
    }
}