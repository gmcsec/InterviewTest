using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Interfaces
{
    public class ChildInterface : IChildInterface 
    {
        public void ChildInterfaceMethod()
        {
            Console.WriteLine("ChildInterfaceMethod() called from ChildInterface Class.");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called from ChildInterface Class.");
        }

    }
}
