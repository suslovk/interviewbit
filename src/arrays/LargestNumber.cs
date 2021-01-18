using System;
using System.Collections.Generic;
using System.Linq;

namespace arrays
{
    public class LargestNumber
    {
        public static string Generate(List<int> arr)
        {
            var allZeros = arr.All(t => t == 0);
            if (allZeros)
                return "0";
            
            var comparer = new LargesNumberComparer();
            arr.Sort(comparer);

            return string.Concat(arr);
        }

        private class LargesNumberComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x == y)
                    return 0;

                var xString = x.ToString();
                var yString = y.ToString();
            
                return long.Parse(xString + yString) > long.Parse(yString + xString) ? -1 : 1;
            }
        }
    }
}