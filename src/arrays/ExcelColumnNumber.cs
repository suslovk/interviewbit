using System;

namespace arrays
{
    public class ExcelColumnNumber
    {
        public static int Get(string columnNumber)
        {
            var result = 0;
            for (var i = 0; i < columnNumber.Length; i++)
            {
                var dig = columnNumber[i] - 'A' + 1;
                result += dig * (int) Math.Pow(26, columnNumber.Length - i - 1);
            }
        
            return result;
        }
    }
}