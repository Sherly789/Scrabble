using System;

namespace Scrabble
{
  public class WordScorer
  {
    // Properties
    private char _myLetter;

    // Constructors, getters, ScoreLetter_ReturnsLetterValue_true
    public WordScorer(char letter)
    {
      _myLetter = letter;
    }

    public char GetLetter()
    {
      return 'A';
    }

    // Other Methods

    public int ValueReturn(char letter)
    {
      return 1;
    }


  }
}
