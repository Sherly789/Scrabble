using Xunit;
using System;

namespace Scrabble
{
  public class WordScorerTest
  {
    [Fact]
    public void ScoreLetter_ReturnsLetter_true()
    {
      // Arrange
      char myLetter = 'A';
      // Act
      WordScorer myWordScorer = new WordScorer(myLetter);
      char myLetterResult = myWordScorer.GetLetter();
      // Assert
      Assert.Equal(myLetter, myLetterResult);
    }

    [Fact]
    public void ScoreLetter_ReturnsLetterValue_true()
    {
      // Arrange
      char myLetter = 'A';
      int myValue = 1;
      // Act
      WordScorer myWordScorer = new WordScorer(myLetter);
      int myValueResult = myWordScorer.ValueReturn(myLetter);
      // Assert
      Assert.Equal(myValue, myValueResult);
    }

    [Fact]
    public void ReturnLetterGroupValue_ReturnsLetterGroupValue_LetterGroupValueReturned()
    {
      // Arrange
      char[] myLetterArray = new char[] { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
      int myValue = 1;
      // Act
      WordScorer myWordScorer = new WordScorer(myLetterArray);
      int myResult = myWordScorer.GetIntFromLetterArray();
      // Assert
      Assert.Equal(myValue, myResult);
    }

  }
}
