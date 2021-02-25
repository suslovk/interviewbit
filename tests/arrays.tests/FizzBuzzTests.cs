using Xunit;

namespace arrays
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(5, "1", "2", "Fizz", "4", "Buzz")]
        [InlineData(15, "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz")]
        public void Solve_ShouldPass(int number, params string[] expected)
        {
            var result = FizzBuzz.Solve(number);
            Assert.Equal(string.Join(',', expected), string.Join(',', result));
        }
    }
}