namespace CPP.Lab1;
public static class StringExtensions
{
    /// <summary>
    /// Remove words with length of <paramref name="maxWordLength"/> or less. Doesn't preserve multiple spaces
    /// </summary>
    /// <param name="str">Original string</param>
    /// <param name="maxWordLength">Max length of the word which will be removed</param>
    /// <returns>Processed string</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string RemoveWordsOfMaxLength(this string str, int maxWordLength)
    {
        if (maxWordLength <= 0)
        {
            throw new ArgumentException("Word length cannot be smaller than 1");
        }

        var correctWords = str
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length > maxWordLength);

        return string.Join(' ', correctWords);
    }
}
