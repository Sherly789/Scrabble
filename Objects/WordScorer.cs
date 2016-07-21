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
      return _myLetter;
    }

    // Other Methods


  }
}
