using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class WordTests
  {
    // Test methods go here
    [TestMethod]
    public void WordReplacer_FindtheWord_String()
    {
      Word testWord = new Word();
      // create string to change: "Hello World"
      Assert.AreEqual("Hello", testWord.WordReplacer("Hello"));
    }

     [TestMethod]
    public void WordReplacer_ReplacetheWord_String()
    {
      Word testWord = new Word();
      // create string to change: "Hello World"
      Assert.AreEqual("Hello Universe", testWord.WordReplacer("World", "Universe"));
    }
  }
}