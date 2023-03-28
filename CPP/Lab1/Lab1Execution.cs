namespace CPP.Lab1;
public static class Lab1Execution
{
    private const int MaxWordLength = 3;

    /// <summary>
    /// Remove words with length of 3 or less. Doesn't preserve multiple spaces
    /// </summary>
    /// <param name="str">Original string</param>
    /// <returns>Processed string</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string RemoveWordWithLengthOfThreeOrLess(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentNullException(nameof(str));
        }

        var correctWords = "";

        foreach(var word in str.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if(word.Length > MaxWordLength)
            {
                correctWords += " " + word;
            }
        }

        return correctWords;
    }
}
