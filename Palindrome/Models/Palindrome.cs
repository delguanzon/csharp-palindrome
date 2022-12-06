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

        public bool IsPalindrome() {
            char[] charArrayReverse = _word.ToCharArray();
            Array.Reverse(charArrayReverse);
            string wordReverse = String.Concat(charArrayReverse);
            Console.WriteLine(wordReverse);
            if (wordReverse == _word) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        
    }
}