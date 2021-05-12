using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_StateDesignPattern
{
    public interface EmployeeState
    {
        void AccessEmployeeService();
        void AccessHrServices();
        void SeparationRequest();
        void AccessAlumniPortal();
    }
}
