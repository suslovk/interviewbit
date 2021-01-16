using System.Collections.Generic;

namespace arrays
{
    public class PascalTriangle
    {
        public static List<List<int>> Generate(int rows)
        {
            if (rows == 0)
                return new List<List<int>>();
            
            var result = new List<List<int>>(rows) {new() {1}};
            for (var i = 1; i < rows; i++)
            {
                var row = new List<int>();
                var previousRow = result[i - 1];
                for (var j = 0; j < previousRow.Count + 1; j++)
                    row.Add((j > 0 ? previousRow[j - 1] : 0) + (j < previousRow.Count ? previousRow[j] : 0));
                
                result.Add(row);
            }

            return result;
        }
    }
}