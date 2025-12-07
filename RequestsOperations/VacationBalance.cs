using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.RequestsOperations
{
    public class VacationBalance
    {
        public void UpdateVacationDaysBalance(EFDbContext DbContext, int vacationRequestId)
        {

            var vacation = DbContext.VacationRequests
                .FirstOrDefault(vr => vr.RequestId == vacationRequestId);

            if (vacation == null) throw new Exception("There is no request with this ID");



            var employee = DbContext.Employees
                .FirstOrDefault(e => e.EmployeeNumber == vacation.EmployeeNumber);

            if (employee == null) throw new Exception("Employee not found");



            if (vacation.RequestStateID == 1) throw new Exception("Vacation request is waitng for the decision");

            if (vacation.RequestStateID != 2) throw new Exception("Vacation request is declined");

            if (vacation.RequestStateID == 2)
            {
                if (employee.VacationDaysLeft == 0) throw new Exception("The employee has used all the vacation days");
                else if (employee.VacationDaysLeft < vacation.TotalVacationDays) throw new Exception("the number of requested days is greater than the vacation days left");
                else employee.VacationDaysLeft -= vacation.TotalVacationDays;
            }

            DbContext.SaveChanges();
        }

    }
}
