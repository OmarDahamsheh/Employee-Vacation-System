using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_and_Vacation_Workflow_System.Entity;

namespace Employee_Management_and_Vacation_Workflow_System.RequestsOperations
{
    public class RequestsOperations
    {
        public void CreateVacationRequest(EFDbContext DbContext, string employeeNo, string description, string vacationType, DateOnly startDate, DateOnly endDate)
        {
            var employee = DbContext.Employees
                .FirstOrDefault(e => e.EmployeeNumber == employeeNo);

            if (employee == null) throw new Exception("Employee not found");



            var overlapp = DbContext.VacationRequests
                .Where(vr => vr.EmployeeNumber == employeeNo)
                .Any(vr => startDate <= vr.EndDate && endDate >= vr.StartDate); //elemenate the ovrlapping

            if (overlapp) throw new Exception("There is an overlapp in vacations date");



            int totalDays = (endDate.ToDateTime(TimeOnly.MinValue) - startDate.ToDateTime(TimeOnly.MinValue)).Days; //To get the total days

            var request = new VacationRequest(
                DateTime.Now,
                description,
                employeeNo,
                vacationType,
                startDate,
                endDate,
                totalDays,
                1, null, null
                );
            DbContext.VacationRequests.Add(request);
            DbContext.SaveChanges();
        }

    }
}
