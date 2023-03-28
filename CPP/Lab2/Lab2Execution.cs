namespace CPP.Lab2;

public static class Lab2Execution
{
    /// <summary>
    /// Removes all arrays which have only even elements
    /// </summary>
    /// <param name="jaggedArr">Jagged array of integers</param>
    /// <returns>Jagged array without arrays of only evens elements</returns>
    public static int[][] RemoveArraysOfEvens(int[][] jaggedArr)
    {
        var temp = new int[jaggedArr.Length][];
        var lastIndex = 0;

        foreach (var arr in jaggedArr)
        {
            if (arr.HasOdds())
            {
                temp[lastIndex] = arr;
                lastIndex++;
            }
        }

        return temp.CopyWithLength(lastIndex);
    }

    private static bool HasOdds(this int[] arr)
    {
        foreach (int value in arr)
        {
            if (value % 2 != 0)
            {
                return true;
            }
        }

        return false;
    }

    private static int[][] CopyWithLength(this int[][] arr, int length) 
    { 
        var result = new int[length][];

        for (var i = 0; i < length; i++)
        {
            result[i] = arr[i];
        }

        return result;
    }
}