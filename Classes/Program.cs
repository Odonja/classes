using Utilities;

namespace Classes;

class Program
{
    private static readonly string potatoFileName = @"D:\VisualStudioProjects\exercises\classes\Classes\Files\Potato.txt";
    static void Main(string[] args)
    {
        IWordCountInterface wordCounter = new WordCounter();
        var numberOfWordsInEachLine = wordCounter.CountWords(potatoFileName);
        Console.WriteLine("The number of words in each line of the potato file is:");
        numberOfWordsInEachLine.ForEach(numberOfWords => Console.WriteLine(numberOfWords));
    }
}