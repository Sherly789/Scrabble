using System;
using System.Collections.Generic;


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

    // method that accepts two parameters. First, a group of characters with a shared number value. Second, a single letter. It takes the letter and checks to see whether that group (array) contains that single letter. If it does, then it returns that shared value. For example, if the single letter = A, if A exists in the array group, then it returns the sahred numberic value.

    public int CompareLetters(char[] letterarray, char myLetter)
    {
      foreach(var letter in letterarray)
      {
        if (letter == myLetter)
        {
          return 1;
        }
        else
        {
          return 0;
        }
      }
      return 0;
    }

  }
}
