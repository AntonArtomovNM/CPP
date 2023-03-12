using System.Text;

namespace CPP.Lab1;
public static class StringExtensions
{
    /// <summary>
    /// Remove characters which repeat at any position
    /// </summary>
    /// <param name="str">Original string</param>
    /// <returns>Processed string</returns>
    public static string RemoveWordsWithRepeatingCharacters(this string str)
    {
        var words = str
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Where(w => w.Length == w.Distinct().Count());

        return string.Join(' ', words);
    }

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

    /// <summary>
    /// Remove words with length of <paramref name="maxWordLength"/> or less. Preserves multiple spaces
    /// </summary>
    /// <param name="str">Original string</param>
    /// <param name="maxWordLength">Max length of the word which will be removed</param>
    /// <returns>Processed string</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string RemoveWordsOfMaxLengthPreserveSpaces(this string str, int maxWordLength)
    {
        if (maxWordLength <= 0)
        {
            throw new ArgumentException("Word length cannot be smaller than 1");
        }

        var wordsToRemove = str
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Where(w => w.Length <= maxWordLength);

        var strBuilder = new StringBuilder(str);

        foreach (var word in wordsToRemove)
        {
            strBuilder.Replace(word, string.Empty);
        }

        return strBuilder.ToString();
    }
}
