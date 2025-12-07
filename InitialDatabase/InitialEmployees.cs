
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_and_Vacation_Workflow_System.Entity;

namespace Employee_Management_and_Vacation_Workflow_System.InitialDatabase
{
    public class InitialEmployees
    {
        public void AddEmployees(EFDbContext DbContext)
        {
            var employees = new List<Employee>
        {
            new Employee("1","Omar",2,4,null,"M",24,1000),
            new Employee("2","Khaled",5,6,"1","M",24,1500),
            new Employee("3","Othman",10,8,"1","M",24,1300),
            new Employee("4","Mariam",15,10,"1","F",24,1200),
            new Employee("5","Maha",4,13,"1","F",24,1100),
            new Employee("6","Ammar",5,14,"1","M",24,1600),
            new Employee("7","Yara",7,11,"1","F",24,600),
            new Employee("8","Reem",8,20,"1","F",24,900),
            new Employee("9","Salem",18,13,"1","M",24,800),
            new Employee("10","Yasmeen",3,1,"1","F",24,800),
        };

            DbContext.Employees.AddRange(employees);
            DbContext.SaveChanges();
        }
    }
}
