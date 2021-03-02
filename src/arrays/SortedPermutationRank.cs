namespace arrays
{
    public class SortedPermutationRank
    {
        public static int Solve(string str)
        {
            var lessThanCurrentCount = new int[str.Length];
            for (var i = 0; i < str.Length; i++)
            for (var j = i + 1; j < str.Length; j++)
                if (str[j] < str[i])
                    lessThanCurrentCount[i]++;

            var rank = 1L;
            for (var i = 0; i < str.Length; i++)
                rank += lessThanCurrentCount[i] * Factorial(str.Length - i - 1) % 1000003;

            return (int) rank % 1000003;
        }

        private static long Factorial(long i)
        {
            if (i < 2)
                return 1L;

            return i * Factorial(i - 1);
        }
    }
}