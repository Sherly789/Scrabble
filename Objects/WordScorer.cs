using System;

namespace Scrabble
{
  public class WordScorer
  {
    // Properties
    private char _myLetter;
    private char[] _myLetterArray;

    // Constructors, getters, ScoreLetter_ReturnsLetterValue_true
    public WordScorer(char letter)
    {
      _myLetter = letter;
    }
    // constructor which takes an array of Char
    public WordScorer(char[] letter)
    {
      _myLetterArray = letter;
    }

    public char GetLetter()
    {
      // return _myLetter;
      return 'A';
    }

    public int GetIntFromLetterArray()
    {
      return 1;
    }

    // Other Methods

    public int ValueReturn(char letter)
    {
      return 1;
    }


  }
}
