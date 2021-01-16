using System.Linq;
using Xunit;

namespace arrays
{
    public class PascalTriangleTests
    {
        [Theory]
        [InlineData(2, "1;1,1")]
        [InlineData(3, "1;1,1;1,2,1")]
        [InlineData(4, "1;1,1;1,2,1;1,3,3,1")]
        [InlineData(5, "1;1,1;1,2,1;1,3,3,1;1,4,6,4,1")]
        [InlineData(6, "1;1,1;1,2,1;1,3,3,1;1,4,6,4,1;1,5,10,10,5,1")]
        [InlineData(7, "1;1,1;1,2,1;1,3,3,1;1,4,6,4,1;1,5,10,10,5,1;1,6,15,20,15,6,1")]
        public void Generate_ShouldReturnValidTriangle(int rows, string expected)
        {
            var result = PascalTriangle.Generate(rows);
            var actual = string.Join(';', result.Select(r => string.Join(',', r)));
            Assert.Equal(expected, actual);
        }
    }
}