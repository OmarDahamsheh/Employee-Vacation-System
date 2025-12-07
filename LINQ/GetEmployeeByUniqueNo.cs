using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_and_Vacation_Workflow_System.Entity;

namespace Employee_Management_and_Vacation_Workflow_System.LINQ
{
    public class GetEmployeeByUniqueNo
    {
        public void GetEmployeeByNo(EFDbContext DbContext, string employeeNo) {

            var employee = (from e in DbContext.Employees
                            where e.EmployeeNumber == employeeNo
                            join m in DbContext.Employees
                            on e.ReportedToEmployeeNumber equals m.EmployeeNumber into mgr
                            from manager in mgr.DefaultIfEmpty()
                            select new
                            {
                                e.EmployeeNumber,
                                e.EmployeeName,
                                e.Department.DepartmentName,
                                e.Position.PositionName,
                                reportedName = manager.EmployeeName,
                                e.VacationDaysLeft
                            }).FirstOrDefault();

            if (employee == null) throw new Exception("Employee not found");

            Console.WriteLine(employee.EmployeeNumber);
            Console.WriteLine(employee.EmployeeName);
            Console.WriteLine(employee.DepartmentName);
            Console.WriteLine(employee.PositionName);
            Console.WriteLine(employee.reportedName);
            Console.WriteLine(employee.VacationDaysLeft);


        }

    }
}
