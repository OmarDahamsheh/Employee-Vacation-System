using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.Entity
{
     public class Department
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //it is by default for int primary key
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string DepartmentName { get; set; }


        public Employee[] Employees { get; set; }
        public Department( string DepartmentName) { 
            this.DepartmentName = DepartmentName;
        }
        public Department()
        {
        }
    }
}
