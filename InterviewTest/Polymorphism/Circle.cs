using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Polymorphism
{
    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }
}
