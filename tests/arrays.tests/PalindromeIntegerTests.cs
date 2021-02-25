using Xunit;

namespace arrays
{
    public class PalindromeIntegerTests
    {
        [Theory]
        [InlineData(12121, true)]
        [InlineData(1234, false)]
        [InlineData(455554, true)]
        public void IsPalindrome_ShouldPass(int input, bool expectedResult)
        {
            var isPalindrome = PalindromeInteger.IsPalindrome(input);
            Assert.Equal(expectedResult, isPalindrome);
        }
    }
}