using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    class ReverseString_NoStack
    {
        static void swap(char[] a, int index1, int index2)
        {
            char temp = a[index1];
            a[index1] = a[index2];
            a[index2] = temp;
        }

        public static void ReverseArray(char[] str)
        {
            int n = str.Length, i;

            for (i = 0; i < n / 2; i++)
            {
                swap(str, i, n - i - 1);
            }
        }

        public static void AddTextToString(ref string s )
        {
            s = s + "addedtext";             
        }
    }
}
