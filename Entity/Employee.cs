using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.Entity
{
    public class Employee
    {
        [Key]
        [MaxLength(6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Not an identity column
        public string EmployeeNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string EmployeeName { get; set; }


        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<VacationRequest> VacationRequests { get; set; }

        [Required]
        public int PositionId { get; set; }
        public Position Position { get; set; }


        [MaxLength(6)]
        public string? ReportedToEmployeeNumber { get; set; }


        [MaxLength(1)]
        [RegularExpression("M|F",ErrorMessage ="The type must be only M or F")]
        public string Gender { get; set; }

            
        [Range(0,24)]
        public int VacationDaysLeft { get; set; }


        [Column(TypeName ="decimal(18,2)")]
        public decimal Salary { get; set; }


        public Employee(string EmployeeNumber, string EmployeeName, int DepartmentId, int PositionId, string ReportedToEmployeeNumber,string Gender, int VacationDaysLeft, decimal Salary)
        {
            this.EmployeeNumber = EmployeeNumber;
            this.EmployeeName = EmployeeName;
            this.DepartmentId = DepartmentId;
            this.PositionId = PositionId;
            this.ReportedToEmployeeNumber = ReportedToEmployeeNumber;
            this.Gender = Gender;
            this.VacationDaysLeft = VacationDaysLeft;
            this.Salary = Salary;
        }

        public Employee()
        {
        }

    }
}
