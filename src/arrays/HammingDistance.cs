using System.Collections.Generic;
using System.Linq;

namespace arrays
{
    public class HammingDistance
    {
        public static int Calculate(List<int> arr)
        {
            int result = 0, max = arr.Max(), pow = 1;
            while (max >= pow)
            {
                int setCount = 0, notSetCount = 0;
                for (var i = 0; i < arr.Count; i++)
                {
                    if ((arr[i] & pow) == pow)
                        setCount++;
                    else
                        notSetCount++;
                }

                result += 2 * setCount * notSetCount;
                pow <<= 1;
            }

            return result;
        }
    }
}