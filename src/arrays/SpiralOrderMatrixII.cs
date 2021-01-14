using System.Collections.Generic;
using System.Linq;

namespace arrays
{
    // ReSharper disable once InconsistentNaming
    public class SpiralOrderMatrixII
    {
        public static List<List<int>> Generate(int dimensions)
        {
            var result = new int[dimensions][];
            for (var i = 0; i < dimensions; i++)
                result[i] = new int[dimensions];

            int number = 1,
                left = 0,
                right = dimensions - 1,
                top = 0,
                down = dimensions - 1,
                // 0 - right, 1 - down, 2 - left, 3 - up
                direction = 0;

            while (number <= dimensions * dimensions)
            {
                switch (direction % 4)
                {
                    case 0:
                        for (var i = left; i <= right; i++)
                            result[top][i] = number++;
                        top++;
                        break;
                    case 1:
                        for (var i = top; i <= down; i++)
                            result[i][right] = number++;
                        right--;
                        break;
                    case 2:
                        for (var i = right; i >= left; i--)
                            result[down][i] = number++;
                        down--;
                        break;
                    case 3:
                        for (var i = down; i >= top; i--)
                            result[i][left] = number++;
                        left++;
                        break;
                }

                direction++;
            }
            
            return result.Select(r => r.ToList()).ToList();
        }
    }
}