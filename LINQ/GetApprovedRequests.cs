using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.LINQ
{
    public class GetApprovedRequests
    {
        public void GetAllApprovedRequests(EFDbContext DbContext) {
            var employees = (from e in DbContext.VacationRequests
                             where e.RequestStateID == 2
                             join m in DbContext.Employees on e.ApprovedByEmployeeId equals m.EmployeeNumber into mgr
                             from manager in mgr.DefaultIfEmpty()
                             select new {
                                 e.VacationType.VacationTypeName,
                                 e.Description,
                                 e.TotalVacationDays,
                                 managerName=manager
                             }).ToList();
        
           foreach(var emp in employees)Console.WriteLine(emp);
        }
    }
}
