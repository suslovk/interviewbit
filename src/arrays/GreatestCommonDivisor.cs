namespace arrays
{
    public class GreatestCommonDivisor
    {
        public static int Get(int first, int second)
        {
            if (first < second)
                return Get(second, first);

            if (second == 0)
                return first;

            return Get(second, first % second);
        }
    }
}