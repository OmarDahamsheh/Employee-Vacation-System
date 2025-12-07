using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_and_Vacation_Workflow_System.LINQ
{
    public class GetEmployeeMainInfo
    {
        public void GetEmployeeInfo(EFDbContext DbContext)
        {
            var employees = (from employee in DbContext.Employees
                             select new
                             {
                                 employee.EmployeeNumber,
                                 employee.EmployeeName,
                                 employee.Department.DepartmentName,
                                 employee.Salary
                             }).ToList();


            foreach (var emp in employees) Console.WriteLine(emp);
        }
    }
}
