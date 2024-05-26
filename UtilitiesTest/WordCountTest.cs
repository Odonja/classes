using Utilities;

namespace UtilitiesTest;

[TestClass]
public class WordCountTest
{
    [TestMethod]
    [DataTestMethod]
    [DataRow(@"d:\VisualStudioProjects\exercises\classes\UtilitiesTest\TestFiles\NoLines.txt", 0, new int[] { })]
    [DataRow(@"d:\VisualStudioProjects\exercises\classes\UtilitiesTest\TestFiles\OneLine.txt", 1, new int[] { 8 })]
    [DataRow(@"d:\VisualStudioProjects\exercises\classes\UtilitiesTest\TestFiles\MultipleLines.txt", 9, new int[] { 3, 6, 6, 2, 2, 2, 4, 0, 0 })]
    public void CountWords_fileWithMultipleAmountsOfLines_returnsWordCountForEachLine(string fileName, int expectedNumberOfLines, int[] wordCountPerLine)
    {
        // given
        var wordCounter = new WordCounter();

        // when
        var result = wordCounter.CountWords(fileName);

        // then
        Assert.AreEqual(expectedNumberOfLines, result.Count, $"expected {expectedNumberOfLines} lines, actual: {result.Count}");
        Assert.IsTrue(new List<int>(wordCountPerLine).SequenceEqual(result));
    }
}