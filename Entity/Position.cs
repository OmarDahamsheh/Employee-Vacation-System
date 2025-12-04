using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.Entity
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        [MaxLength(30)]
        public String PositionName { get; set; }

        public Employee[] Employees { get; set; }

        public Position(string PositionName)
        {
            this.PositionName = PositionName;
        }

        public Position()
        {
        }
    }
}
