using System.Linq;
using Xunit;

namespace arrays
{
    public class RotateMatrixTests
    {
        [Theory]
        [InlineData("1,2;3,4", "3,1;4,2")]
        [InlineData("1,2,3;4,5,6;7,8,9", "7,4,1;8,5,2;9,6,3")]
        [InlineData("1,2,3,4;5,6,7,8;9,10,11,12;13,14,15,16", "13,9,5,1;14,10,6,2;15,11,7,3;16,12,8,4")]
        public void Rotate_ShouldReturnValidMatrix(string arrayString, string expectedResultString)
        {
            var array = Str2Arr(arrayString);
            RotateMatrix.Rotate(array);
            Assert.Equal(expectedResultString, Arr2Str(array));
        }

        private static int[][] Str2Arr(string str) =>
            str.Split(';').Select(s => s.Split(',').Select(int.Parse).ToArray()).ToArray();
        
        private static string Arr2Str(int[][] arr) =>
            string.Join(';', arr.Select(r => string.Join(',', r)));
    }
}