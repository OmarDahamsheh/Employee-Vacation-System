using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.Entity
{
    public class VacationRequest
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        public DateTime RequestSubmissionDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }


        public string EmployeeNumber { get; set; }
        public Employee Employee { get; set; }

        [MaxLength(1)]
        public string VacationTypeId { get; set;}
        public VacationType VacationType { get; set; }

        [Required]
        public DateOnly StartDate { get; set; }

        [Required]
        public DateOnly EndDate { get; set; }

        [Required]
        public int TotalVacationDays { get; set; }

        [Required]
        public int RequestStateID { get; set; }
        public RequestState RequestState { get; set; }


        public string? ApprovedByEmployeeId { get; set;}
        public string? DeclinedByEmployeeId { get; set;}

        public VacationRequest(DateTime RequestSubmissionDate, string Description, string EmployeeNumber, string VacationTypeId, DateOnly StartDate, DateOnly EndDate, int TotalVacationDays, int RequestStateID, string ApprovedBy, string DeclinedBy) {
            this.RequestSubmissionDate = RequestSubmissionDate;
            this.Description = Description;
            this.EmployeeNumber = EmployeeNumber;
            this.VacationTypeId = VacationTypeId;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.TotalVacationDays = TotalVacationDays;
            this.RequestStateID = RequestStateID;
            this.ApprovedByEmployeeId = ApprovedBy;
            this.DeclinedByEmployeeId = DeclinedBy;
        }
        public VacationRequest()
        { 
        }
    }
}
