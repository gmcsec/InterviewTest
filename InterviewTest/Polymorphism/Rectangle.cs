﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Polymorphism
{
    public class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle()
        {
            Height = 5.3;
            Width = 3.4;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }
}
