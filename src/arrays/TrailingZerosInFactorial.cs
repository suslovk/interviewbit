namespace arrays
{
    public class TrailingZerosInFactorial
    {
        public static int Count(int num)
        {
            var result = 0;
            var pow = 5;
            while (pow <= num)
            {
                result += num / pow;
                pow *= 5;
            }

            return result;
        }
    }
}