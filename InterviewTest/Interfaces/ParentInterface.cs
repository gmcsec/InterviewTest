using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Interfaces
{
    public class ParentInterface : IParentInterface
    {
        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called from ParentInterface.");
        }
    }
}
