using System.Text.RegularExpressions;

namespace Utilities;

public class WordCounter : IWordCountInterface
{
    public List<int> CountWords(string filename)
    {
        List<int> wordCountPerLine = new List<int>();

        using (StreamReader sr = new StreamReader(filename))
        {
            string? line;
            // Read and display lines from the file until the end of
            // the file is reached.

            while ((line = sr.ReadLine()) != null)
            {
                string alphaLine = ReplaceNonAlphaCharacters(line);
                int numberOfWordsInLine = CountNumberOfWords(alphaLine);
                wordCountPerLine.Add(numberOfWordsInLine);
            }
        }
        return wordCountPerLine;
    }

    private static int CountNumberOfWords(string input)
    {
        return Regex.Count(input, "[\\w]+");
    }

    private static string ReplaceNonAlphaCharacters(string input)
    {
        return Regex.Replace(input, "[^a-zA-Z]", " ");
    }
}
