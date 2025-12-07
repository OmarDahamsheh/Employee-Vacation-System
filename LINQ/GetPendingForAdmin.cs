using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.LINQ
{
    public class GetPendingForAdmin
    {
        public void GetAllPendingRequestsForAdmins(EFDbContext DbContext) {
            var requests = (from r in DbContext.VacationRequests
                            where r.RequestStateID == 1
                            select new
                            {
                                r.Description,
                                r.EmployeeNumber,
                                r.Employee.EmployeeName,
                                r.RequestSubmissionDate,
                                r.TotalVacationDays,
                                r.StartDate,
                                r.EndDate,
                                r.Employee.Salary
                            }).ToList();

            foreach (var req in requests) Console.WriteLine(req);
        }
    }
}
