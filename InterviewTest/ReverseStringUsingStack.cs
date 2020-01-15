using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    class ReverseStringUsingStack
    {
        public static void ReverseArray(char[] str)
        {
            int StringLength = str.Length;
            
            Stack<char> OriginalStack = new Stack<char>();
            foreach (char c in str)
            {
                OriginalStack.Push(c);
            }
            for (int i = 0; i < StringLength; i++)
            {
                str[i] = OriginalStack.Pop();
            }
        }

        public static string ReverseString(string str)
        {
            string ReversedString = string.Empty;
            int StringLength = str.Length;
            char[] CharArray = str.ToCharArray();

            Stack<char> OriginalStack = new Stack<char>();
            foreach (char c in str)
            {
                OriginalStack.Push(c);
            }
            for (int i = 0; i < StringLength; i++)
            {
                CharArray[i] = OriginalStack.Pop();
            }
            return string.Join("", CharArray);
        }
    }
}
