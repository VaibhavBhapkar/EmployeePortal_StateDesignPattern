using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_StateDesignPattern
{
    public class InActiveEmployeeState:EmployeeState
    {
        public void AccessAlumniPortal()
        {
            Console.WriteLine("Welcome to alumni portal");
        }

        public void AccessEmployeeService()
        {
            Console.WriteLine("Unauthorized to view this portal");
        }

        public void AccessHrServices()
        {
            Console.WriteLine("Unauthorized to view this portal");
        }

        public void SeparationRequest()
        {
            Console.WriteLine("Unauthorized to view this portal");
        }
    }
}
