using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.UpdateEmployeeMainInfo
{
    public class UpdateEmployeeInfo
    {
        public void UpdateEmployeeMainInfo(EFDbContext DbContext, string EmployeeNo, string newName, int newDepartmentId, int newPositionId, decimal newSalary)
        {
            var employee = DbContext.Employees
                .FirstOrDefault(e => e.EmployeeNumber == EmployeeNo);

            if (employee == null) throw new Exception("Employee not found");

            employee.EmployeeName = newName;
            employee.DepartmentId = newDepartmentId;
            employee.PositionId = newPositionId;
            employee.Salary = newSalary;

            DbContext.SaveChanges();
        }
    }
}
