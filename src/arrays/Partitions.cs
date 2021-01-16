using System.Collections.Generic;

namespace arrays
{
    public class Partitions
    {
        public static int GetSplitsCount(int arrLength, List<int> arr)
        {
            var sumOfAllElements = 0L;
            for (var i = 0; i < arrLength; i++)
                sumOfAllElements += arr[i];
            
            if (sumOfAllElements % 3 != 0)
                return 0;
            
            var prefixArray = new int[arrLength];
            prefixArray[0] = arr[0];
            for (var i = 1; i < prefixArray.Length; i++)
                prefixArray[i] = prefixArray[i - 1] + arr[i];

            var suffixArray = new int[arrLength];
            suffixArray[^1] = arr[^1];
            for (var i = suffixArray.Length - 2; i >= 0; i--)
                suffixArray[i] = suffixArray[i + 1] + arr[i];

            var sumOfOnePart = sumOfAllElements / 3;
            var partitionsCount = 0;
            for (var i = 0; i < arrLength; i++)
            {
                if (prefixArray[i] != sumOfOnePart) 
                    continue;
                
                for (var j = i + 2; j < arrLength; j++)
                    if (suffixArray[j] == sumOfOnePart)
                        partitionsCount++;
            }

            return partitionsCount;
        }
    }
}