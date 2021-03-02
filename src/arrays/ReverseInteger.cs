namespace arrays
{
    public class ReverseInteger
    {
        public static int Solve(int input)
        {
            var invertResult = false;
            if (input < 0)
            {
                input = -input;
                invertResult = true;
            }

            var result = 0;
            while (input > 0)
            {
                if (int.MaxValue / 10 < result || int.MaxValue / 10 == result && int.MaxValue % 10 < input % 10)
                    return 0;
                
                result = result * 10 + input % 10;
                input /= 10;
            }

            return invertResult ? -result : result;
        }
    }
}