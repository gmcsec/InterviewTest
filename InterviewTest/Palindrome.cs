using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTest
{
    public class Palindrome
    {
        public bool IsPalindrome(string text1, string text2)
        {
            bool IsPalindrome = true;

            if (text1.Length != text2.Length) return false;
            else
            {
                char[] Array1 = text1.ToCharArray();
                char[] Array2 = text2.ToCharArray();
                Array.Reverse(Array2);
                                
                for (int x = 0; x < Array1.Length; x++)
                {
                    if (!Array1[x].Equals(Array2[x]))
                    {
                        Console.WriteLine("Text1: " + text1 + " is not a palindrome of Text2 " + text2);
                        IsPalindrome = false;
                        break;
                    }
                }
                if (IsPalindrome) Console.WriteLine("Text1: " + text1 + " is a palindrome of Text2 " + text2);
            }

            return IsPalindrome;

        }
    }
}
