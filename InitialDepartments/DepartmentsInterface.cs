using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_and_Vacation_Workflow_System.Entity;

namespace Employee_Management_and_Vacation_Workflow_System.InitialDepartments
{
    interface DepartmentsInterface
    {
        public void AddDepartments(EFDbContext DbContext);
    }
}
