using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_StateDesignPattern
{
    public class ActiveEmployeeState : EmployeeState
    {
        public void AccessAlumniPortal()
        {
            Console.WriteLine("You are an active employee of org. You dont have access to alumni portal");
        }

        public void AccessEmployeeService()
        {
            Console.WriteLine("Welcome to employee service");
        }

        public void AccessHrServices()
        {
            Console.WriteLine("Welcome to hr service");
        }

        public void SeparationRequest()
        {
            Console.WriteLine("Separation request raised");
        }
    }
}
