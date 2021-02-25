using System.Collections.Generic;

namespace arrays
{
    public class FizzBuzz
    {
        public static List<string> Solve(int num)
        {
            var list = new List<string>(num);
            for (var i = 1; i <= num; i++)
            {
                if (i % 15 == 0)
                    list.Add("FizzBuzz");
                else if (i % 3 == 0)
                    list.Add("Fizz");
                else if (i % 5 == 0)
                    list.Add("Buzz");
                else
                    list.Add(i.ToString());
            }

            return list;
        }
    }
}