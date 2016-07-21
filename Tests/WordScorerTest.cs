using Xunit;
using System;

namespace Scrabble
{
  public class WordScorerTest
  {
    [Fact]
    public void ScoreLetter_ReturnsLetterValue_true()
    {
      // Arrange
      char myLetter = 'A';
      // Act
      WordScorer myWordScorer = new Wordscorer(myLetter);
      char myLetterResult = myWordScorer.GetLetter();
      // Assert
      Assert.Equal(myLetter, myLetterResult);
    }

  }
}
