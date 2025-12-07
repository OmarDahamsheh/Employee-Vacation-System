using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_and_Vacation_Workflow_System.RequestsOperations
{
    public class ResponseToVacation
    {
        public void ApproveRequest(EFDbContext DbContext, int requestId)
        {
            var request = DbContext.VacationRequests
                .Include(vr => vr.Employee)
                .FirstOrDefault(vr => vr.RequestId == requestId);

            if (request == null) throw new Exception("Request not found");
            if (request.RequestStateID != 1) throw new Exception("Request is not in pending state");

            var manager = DbContext.Employees
                    .FirstOrDefault(e => e.EmployeeNumber == request.Employee.ReportedToEmployeeNumber);
            if (manager == null) throw new Exception("Manager not found");


            request.RequestStateID = 2; // Approved
            request.Employee.VacationDaysLeft -= request.TotalVacationDays;// Reduce vacation days
            request.ApprovedByEmployeeId = request.Employee.ReportedToEmployeeNumber;
            DbContext.SaveChanges();
        }
        public void DeclineRequest(EFDbContext DbContext, int requestId)
        {
            var request = DbContext.VacationRequests
                .FirstOrDefault(vr => vr.RequestId == requestId);

            if (request == null) throw new Exception("Request not found");
            if (request.RequestStateID != 1) throw new Exception("Request is not in pending state");

            var manager = DbContext.Employees.FirstOrDefault(e => e.EmployeeNumber == request.Employee.ReportedToEmployeeNumber);
            if (manager == null) throw new Exception("Manager not found");

            request.RequestStateID = 3; // Declined
            request.DeclinedByEmployeeId = request.Employee.ReportedToEmployeeNumber;
            DbContext.SaveChanges();
        }
    }
}
