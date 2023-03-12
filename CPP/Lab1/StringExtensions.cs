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
}
