using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.UpdateEmployeeMainInfo
{
    public interface UpdateEmployeeInfoInterface
    {
        public void UpdateEmployeeMainInfo(EFDbContext DbContext, string EmployeeNo, string newName, int newDepartmentId, int newPositionId, decimal newSalary);
    }
}
