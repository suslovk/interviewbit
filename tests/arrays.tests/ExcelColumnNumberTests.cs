using Xunit;

namespace arrays
{
    public class ExcelColumnNumberTests
    {
        [Theory]
        [InlineData("C", 3)]
        [InlineData("AB", 28)]
        [InlineData("GCT", 4830)]
        public void Get_ShouldPass(string input, int expected)
        {
            var result = ExcelColumnNumber.Get(input);
            Assert.Equal(expected, result);
        }
    }
}