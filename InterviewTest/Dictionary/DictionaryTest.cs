using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Dictionary
{
    public class DictionaryTest
    {
        public Dictionary<string, int> GetDaysPerMonth(int year)
        {
            Dictionary<string, int> DaysPerMonth = new Dictionary<string, int>();
            try
            {
                
                DaysPerMonth.Add("January", 31);
                if (year % 4 == 0) DaysPerMonth.Add("February", 29);
                else DaysPerMonth.Add("February", 28);
                DaysPerMonth.Add("March", 31);
                DaysPerMonth.Add("April", 30);
                DaysPerMonth.Add("May", 31);
                DaysPerMonth.Add("June", 30);
                DaysPerMonth.Add("July", 31);
                DaysPerMonth.Add("August", 31);
                DaysPerMonth.Add("September", 30);
                DaysPerMonth.Add("October", 31);
                DaysPerMonth.Add("November", 30);
                DaysPerMonth.Add("December", 31);
                if (!DaysPerMonth.ContainsKey("December")) DaysPerMonth.Add("December", 30);
            }
            catch(System.ArgumentException ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
            }
            return DaysPerMonth;
        }
    }
}
