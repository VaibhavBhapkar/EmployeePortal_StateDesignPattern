using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_StateDesignPattern
{
    public class EmployeePortal : EmployeeState
    {
        public EmployeeState employeeState { get; set; }
        public EmployeePortal()
        {
            employeeState = new ActiveEmployeeState();
        }
        public void AccessAlumniPortal()
        {
            employeeState.AccessAlumniPortal();
        }

        public void AccessEmployeeService()
        {
            employeeState.AccessEmployeeService();
        }

        public void AccessHrServices()
        {
            employeeState.AccessHrServices();
        }

        public void SeparationRequest()
        {
            employeeState.SeparationRequest();
            
            if (employeeState is ActiveEmployeeState)
            {
                employeeState = new InActiveEmployeeState();
                Console.WriteLine("Employee state has been moved to : "
                                + employeeState.GetType().Name);
            }
        }
    }
}
