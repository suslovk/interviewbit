namespace arrays
{
    public class RotateMatrix
    {
        public static void Rotate(int[][] arr)
        {
            for (var i = 0; i < arr.Length / 2; i++)
            for (var j = i; j < arr.Length - 1 - i; j++)
            {
                var toPut = arr[i][j];
                var toRemember = arr[j][arr.Length - 1 - i];
                arr[j][arr.Length - 1 - i] = toPut;
                toPut = toRemember;
                toRemember = arr[arr.Length - 1 - i][arr.Length - 1 - j];
                arr[arr.Length - 1 - i][arr.Length - 1 - j] = toPut;
                toPut = toRemember;
                toRemember = arr[arr.Length - 1 - j][i];
                arr[arr.Length - 1 - j][i] = toPut;
                arr[i][j] = toRemember;
            }
        }
    }
}