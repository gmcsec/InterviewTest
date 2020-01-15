using InterviewTest.Interfaces;
using InterviewTest.Polymorphism;
using InterviewTest.Recursion;
using InterviewTest.REST;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace InterviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Determine if string1 is a Palindrome of string2
            //Palindrome PalindromeCheck = new Palindrome();
            //PalindromeCheck.IsPalindrome("cat", "tac");
            //PalindromeCheck.IsPalindrome("cat", "tca");
            //PalindromeCheck.IsPalindrome("cat", "act");
            //PalindromeCheck.IsPalindrome("cat", "atc");
            #endregion

            #region Determine if the brackets are properly formed

            #endregion

            #region - Reverse a char[] without using a stack
            char[] str = "GeeksQuiz".ToCharArray();
            string test = "Hello";
            Console.WriteLine("Before calling the reverse method string is " + String.Join("", str));
            ReverseString_NoStack.ReverseArray(str);
            Console.WriteLine("After calling the reverse method string is " + String.Join("", str));
            #endregion

            #region Modify a string reference
            Console.WriteLine("Before calling AddTextToString test = " + test);
            ReverseString_NoStack.AddTextToString(ref test);
            Console.WriteLine("After calling AddTextToString test = " + test);
            #endregion

            #region Reverse a char[] and a string using a stack
            Console.WriteLine("Before calling the ReverseArray method string is " + String.Join("", str));
            ReverseStringUsingStack.ReverseArray(str);
            Console.WriteLine("After calling the ReverseArray method string is " + String.Join("", str));

            string StringToReverse = "GeeksQuiz";
            Console.WriteLine("Before calling the ReverseString method string is " + StringToReverse);
            string ReversedString = ReverseStringUsingStack.ReverseString(StringToReverse);
            Console.WriteLine("After calling the ReverseString method string is " + ReversedString);

            Console.WriteLine("Before calling the ReverseTheString method string is " + StringToReverse);
            ReversedString = Stacks.ReverseString.ReverseTheString(StringToReverse);
            Console.WriteLine("After calling the ReverseTheString method string is " + ReversedString);

            #endregion

            #region Performance Test: String Concatenation vs StringBuilder
            //StringPerformanceTest.StringVSStringBuilder(10000);
            #endregion

            #region - Polymorphism
            Circle circle = new Circle();
            Console.WriteLine("Circle area = " + circle.Area());
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Rectangle area = " + rectangle.Area());

            Salary Pay = new Salary();
            Console.WriteLine("Weekly pay for hourly worker making 15.50/hour for 40 hours = " + Pay.WeeklyPay(40, 15.50m));
            Console.WriteLine("Weekly pay for Salary worker making 104k per year = " + Pay.WeeklyPay(104000));
            #endregion

            #region - Implement Interfaces
            ParentInterface Parent = new ParentInterface();
            Parent.ParentInterfaceMethod();
            ChildInterface Child = new ChildInterface();
            Child.ParentInterfaceMethod();
            Child.ChildInterfaceMethod();
            #endregion

            #region - Are brackets well formed
            BracketTest Brackets = new BracketTest();
            string BracketString = "()({})[}[]";
            if (Brackets.AreBracketsWellFormed(BracketString)) Console.WriteLine("PASS: The following string does have well formed brackets: '" + BracketString + "'");
            else Console.WriteLine("FAIL: The following string does not have well formed brackets: '" + BracketString + "'");
            #endregion

            #region - Recursion
            // Factorial
            Factorial FactorialNumber = new Factorial();
            int Number = 5;
            Console.WriteLine("The factorial of " + Number + " is " + FactorialNumber.GetFactorial(Number));
            // Retrieve files from folder and all subfolders
            string FolderPath = @"C:\Temp\Aspect";
            List<string> ListOfFiles = new List<string>();
            Files.GetFiles(FolderPath, ref ListOfFiles);
            #endregion

            #region - Dictionaries
            int Year = 2019;
            Dictionary<string, int> DaysPerMonth = new Dictionary.DictionaryTest().GetDaysPerMonth(Year);
            foreach (KeyValuePair<string, int> items in DaysPerMonth)
            {
                Console.WriteLine("The month of: " + items.Key + " has " + items.Value + " days in the year: " + Year);
            }
            Year = 2020;
            DaysPerMonth = new Dictionary.DictionaryTest().GetDaysPerMonth(Year);
            foreach (KeyValuePair<string, int> items in DaysPerMonth)
            {
                Console.WriteLine("The month of: " + items.Key + " has " + items.Value + " days in the year: " + Year);
            }
            DaysPerMonth.TryGetValue("November", out int value);
            Console.WriteLine("The month of: " + "November" + " has " + value + " days in the year: " + Year);
            #endregion

            #region - REST
            WebRequest Request = new WebRequest();
            HttpResponseMessage Response = Request.GetCurrentWeather("03079");
            JValue WeatherDetails = Request.GetCurrentWeather2("03079");
            Console.WriteLine("The End");
            #endregion

        }
    }
}
