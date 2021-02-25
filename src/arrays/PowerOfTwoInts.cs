namespace arrays
{
    public class PowerOfTwoInts
    {
        public static bool Solve(int num)
        {
            if (num == 1)
                return true;

            for (var i = 2; i * i <= num; i++)
            {
                var x = num;
                while (x % i == 0)
                {
                    x /= i;
                    if (x == 1)
                        return true;
                }
            }

            return false;
        }
    }
}