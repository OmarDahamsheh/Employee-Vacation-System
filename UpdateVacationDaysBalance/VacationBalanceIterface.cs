using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.UpdateVacationDaysBalance
{
    public interface VacationBalanceIterface
    {
        public void UpdateVacationDaysBalance(EFDbContext DbContext, int VacationRequestId);
    }
}
