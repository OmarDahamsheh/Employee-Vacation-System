using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_and_Vacation_Workflow_System.Entity;

namespace Employee_Management_and_Vacation_Workflow_System.AddInitialPositions
{
    public class InitialPositions : PositionsInterface
    {
        public void AddPositions(EFDbContext DbContext)
        {

            var positions = new List<Position> {
            new Position("Software Engineer"),
            new Position("Senior Software Engineer"),
            new Position("Junior Developer"),
            new Position("Team Leader"),
            new Position("Project Manager"),
            new Position("Human Resources Manager"),
            new Position("HR Specialist"),
            new Position("Accountant"),
            new Position("Senior Accountant"),
            new Position("Financial Analyst"),
            new Position("IT Support Specialist"),
            new Position("Systems Administrator"),
            new Position("Network Engineer"),
            new Position("QA Engineer"),
            new Position("DevOps Engineer"),
            new Position("Product Manager"),
            new Position("Sales Representative"),
            new Position("Marketing Specialist"),
            new Position("Customer Service Agent"),
            new Position("Business Analyst")
        };

            DbContext.Positions.AddRange(positions);
            DbContext.SaveChanges();

        }

    }
}
