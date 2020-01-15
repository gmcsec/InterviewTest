using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    public class StringPerformanceTest
    {
        public static void StringVSStringBuilder(int loopIterations = 50)
        {
            const int sLen = 30;
            DateTime sTime, eTime;
            int i;
            string sSource = new String('X', sLen);
            string sDest = "";
            // 
            // Time string concatenation.
            // 
            sTime = DateTime.Now;
            for (i = 0; i < loopIterations; i++) sDest += sSource;
            eTime = DateTime.Now;
            Console.WriteLine("Concatenation took " + (eTime - sTime).TotalMilliseconds + " milliseconds.");
            // 
            // Time StringBuilder.
            // 
            sTime = DateTime.Now;
            //StringBuilder sb = new StringBuilder((int)(sLen * loopIterations * 1.1));
            StringBuilder sb = new StringBuilder();
            for (i = 0; i < loopIterations; i++) sb.Append(sSource);
            sDest = sb.ToString();
            eTime = DateTime.Now;
            Console.WriteLine("String Builder took " + (eTime - sTime).TotalMilliseconds + " milliseconds.");
            // 
            // Make the console window stay open
            // so that you can see the results when running from the IDE.
            // 
            //Console.WriteLine();
            //Console.Write("Press Enter to finish ... ");
            //Console.Read();
        }
    }
}
