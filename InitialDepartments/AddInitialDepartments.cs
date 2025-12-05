using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_and_Vacation_Workflow_System.Entity;

namespace Employee_Management_and_Vacation_Workflow_System.InitialDepartments
{
    public class AddInitialDepartments : DepartmentsInterface
    {
        public void AddDepartments(EFDbContext DbContext)
        {
            var departments = new List<Department> {
           new Department("Human Resources"),
           new Department("Finance"),
           new Department("Accounting"),
           new Department("Information Technology"),
           new Department("Software Development"),
           new Department("Customer Service"),
           new Department("Sales"),
           new Department("Marketing"),
           new Department("Procurement"),
           new Department("Operations"),
           new Department("Administration"),
           new Department("Quality Assurance"),
           new Department("Research and Development"),
           new Department("Legal Affairs"),
           new Department("Public Relations"),
           new Department("Facilities Management"),
           new Department("Security"),
           new Department("Training and Development"),
           new Department("Logistics"),
           new Department("Product Management")
        };

            foreach (Department i in departments)
            {
                DbContext.Departments.Add(i);
            }

            DbContext.SaveChanges();
        }
    }
}
