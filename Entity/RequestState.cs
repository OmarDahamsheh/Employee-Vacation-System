using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.Entity
{
    public class RequestState
    {
        [Key]
        public int StateId { get; set; }

        [Required]
        [MaxLength(10)]
        public string StateName { get; set; } 
        
        public RequestState(string StateName) { 
            this.StateName = StateName;
        }

        public VacationRequest[] VacationRequests{ get; set; }
        public RequestState() 
        { 
        }

    }

   
}
