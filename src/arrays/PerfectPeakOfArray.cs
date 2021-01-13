using System;
using System.Collections.Generic;

namespace arrays
{
    public class PerfectPeakOfArray
    {
        public static int PeakExists(List<int> arr)
        {
            var maxLeft = arr[0];
            for (var i = 1; i < arr.Count; i++)
            {
                if (arr[i] <= maxLeft)
                    continue;
                
                var potentialPeak = arr[i];
                var maxRight = arr[i];
                var j = i + 1;
                while (j < arr.Count)
                {
                    if (arr[j] <= potentialPeak)
                    {
                        maxLeft = maxRight;
                        i = j;
                        break;
                    }

                    maxRight = Math.Max(maxRight, arr[j]);
                    j++;
                }
                
                if (j == arr.Count)
                    return 1;
            }

            return 0;
        }
    }
}