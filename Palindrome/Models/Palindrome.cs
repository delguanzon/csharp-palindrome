using System;
using System.Collections.Generic;

namespace Models
{
  public class Palindrome
  {
    private string _word;
    public Palindrome(string word)
    {
      _word = word;
    }

    public bool IsPalindrome()
    {
    //   char[] charArrayReverse = _word.ToCharArray();
    //   Array.Reverse(charArrayReverse);
    //   string wordReverse = String.Concat(charArrayReverse);
    //   Console.WriteLine(wordReverse);
      if (Reverse() == _word)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private string Reverse()
    {
      char[] wordArr = _word.ToCharArray();
      char[] reversed = new char[wordArr.Length];
      int ctr = 0;
      for (int i = wordArr.Length - 1; i >= 0; i--)
      {
        reversed[ctr] = wordArr[i];
        ctr++;
      }
      return String.Concat(reversed);
    }
  }
}
