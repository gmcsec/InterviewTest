using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Stacks
{
    public static class ReverseString
    {
        public static string ReverseTheString(string stringToReverse)
        {
            Stack<char> ReverseStack = new Stack<char>();
            foreach (char Character in stringToReverse.ToCharArray())
            {
                ReverseStack.Push(Character);
            }
            string ReverseString = string.Empty;
            while (ReverseStack.Count > 0)
            {
                ReverseString = ReverseString + ReverseStack.Pop();
            }
            return ReverseString;
        }
    }
}
