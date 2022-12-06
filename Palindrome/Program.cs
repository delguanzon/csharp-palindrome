using System;
using System.Collections.Generic;
using Models;

public class Program
{
  public static void Main()
  {

    Console.WriteLine("Enter a word: ");
    string word = Console.ReadLine().ToLower();

    Palindrome palindrome = new Palindrome(word);

    if(palindrome.IsPalindrome()){
      Console.WriteLine("{0} is a palindrome", word);
    }
    else {
      Console.WriteLine("{0} is not a palindrome", word);
    }   
  }
}