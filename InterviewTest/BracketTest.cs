using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    public class BracketTest
    {
        public bool AreBracketsWellFormed(string text)
        {
            Stack<char> MyStack = new Stack<char>();

            char[] TextArray = text.ToCharArray();
            if (TextArray.Length % 2 != 0) return false;
            
            for (int x = 0; x < TextArray.Length - 1; x++)
            {
                if (TextArray[x] == '(' || TextArray[x] == '{' || TextArray[x] == '[')
                {
                    MyStack.Push(TextArray[x]);
                }
                else if (TextArray[x] == ')' || TextArray[x] == '}' || TextArray[x] == ']')
                {
                    if (MyStack.Count == 0) return false;
                    else if (!IsMatchingPair(TextArray[x], MyStack.Pop())) return false;
                }
            }
            return true;
        }

        private bool IsMatchingPair(char closingBracket, char openingBracket)
        {
            switch (closingBracket)
            {
                case ')':
                    if (openingBracket == '(') return true;
                    else return false;
                case '}':
                    if (openingBracket == '{') return true;
                    else return false;
                case ']':
                    if (openingBracket == '[') return true;
                    else return false;
                default:
                    return false;
            }
        }
    }
}
