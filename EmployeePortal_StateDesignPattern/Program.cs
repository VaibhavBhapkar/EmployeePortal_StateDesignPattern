using System;

namespace EmployeePortal_StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePortal employeePortal = new EmployeePortal();
            Console.WriteLine("Employee Current state : "
                            + employeePortal.employeeState.GetType().Name);
            employeePortal.AccessEmployeeService();
            employeePortal.AccessHrServices();
            employeePortal.AccessAlumniPortal();
            employeePortal.SeparationRequest();
            
            Console.WriteLine("Employee Current state : "
                            + employeePortal.employeeState.GetType().Name);

            employeePortal.AccessEmployeeService();
            employeePortal.AccessHrServices();
            employeePortal.AccessAlumniPortal();
            employeePortal.SeparationRequest();
        }
    }
}
