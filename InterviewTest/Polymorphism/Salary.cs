using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Polymorphism
{
    public class Salary
    {
        public decimal WeeklyPay(int annualSalary)
        {
            return annualSalary / 52;
        }

        public decimal WeeklyPay(decimal hoursWorked, decimal hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }
}
