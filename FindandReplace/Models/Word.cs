namespace FindAndReplace
{
  public class Word
  {
        // public string SentenceInput { get; set; }
        // public UserSentence(string sentenceInput)
        // {
        //     SentenceInput = sentenceInput;
        // }

    public string WordReplacer(string word, string replacementWord)
    {
      string SentenceInput = "Hello World";
      if (SentenceInput.Contains(word))
      {
        string newSentence = SentenceInput.Replace(word, replacementWord);
        SentenceInput = newSentence;
      }
      return SentenceInput;
      // return newSentence;
    }
  }
}