using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.AddInitialEmployees
{
    public interface EmployeesInterface
    {
        public void AddEmployees(EFDbContext DbContext);
    }
}
