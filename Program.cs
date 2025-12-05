

using System.Resources;
using Employee_Management_and_Vacation_Workflow_System;
using Employee_Management_and_Vacation_Workflow_System.AddInitialEmployees;
using Employee_Management_and_Vacation_Workflow_System.AddInitialPositions;
using Employee_Management_and_Vacation_Workflow_System.Entity;
using Employee_Management_and_Vacation_Workflow_System.InitialDepartments;
using Employee_Management_and_Vacation_Workflow_System.UpdateEmployeeMainInfo;
using Employee_Management_and_Vacation_Workflow_System.UpdateVacationDaysBalance;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        EFDbContext DbContext = new EFDbContext();

        //AddInitialDepartments obj1= new AddInitialDepartments();
        //obj1.AddDepartments(DbContext);


        //InitialPositions obj2 = new InitialPositions();
        //obj2.AddPositions(DbContext);


        //InitialEmployees obj3 = new InitialEmployees();
        //obj3.AddEmployees(DbContext);


        UpdateEmployeeInfo obj4 = new UpdateEmployeeInfo();
        obj4.UpdateEmployeeMainInfo(DbContext, "3", "Umar", 12, 3, 2000);


        //VacationBalance obj5 = new VacationBalance();
        //obj5.UpdateVacationDaysBalance(DbContext, 1);
    }


}
