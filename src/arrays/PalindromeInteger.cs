using System.Collections.Generic;

namespace arrays
{
    public class PalindromeInteger
    {
        public static bool IsPalindrome(int input) => input == Reverse(input);

        private static int Reverse(int input)
        {
            var reversed = 0;
            while (input > 0)
            {
                reversed *= 10;
                reversed += input % 10;
                input /= 10;
            }

            return reversed;
        }
    }
}