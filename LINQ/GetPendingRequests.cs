using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.LINQ
{
    public class GetPendingRequests
    {
        public void GetAllPendingRequests(EFDbContext DbContext)
        {
            var employees = (from e in DbContext.VacationRequests
                             where e.RequestStateID == 1
                             select new
                             {
                                 e.Employee.EmployeeNumber,
                                 e.Employee.EmployeeName,
                             }).ToList();

            foreach (var emp in employees)
                Console.WriteLine(emp);
        }
    }
}
