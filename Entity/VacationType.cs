using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_and_Vacation_Workflow_System.Entity
{
    public class VacationType
    {
        [Key]
        [MaxLength(1)]
        [RegularExpression("S|U|A|O|B", ErrorMessage = "Invalid Vacation type id")]
        public string VacationTypeId { get; set; }

        [MaxLength(20)]
        public string VacationTypeName { get; set; }

        public VacationRequest[] VacationRequests { get; set; }    


        public VacationType(string VacationTypeName)
        {
            this.VacationTypeName = VacationTypeName;
        }

        public VacationType()
        {
        }
    }
}
