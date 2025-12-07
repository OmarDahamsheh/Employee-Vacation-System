

using System.Resources;
using Employee_Management_and_Vacation_Workflow_System;
using Employee_Management_and_Vacation_Workflow_System.Entity;
using Employee_Management_and_Vacation_Workflow_System.InitialDatabase;
using Employee_Management_and_Vacation_Workflow_System.LINQ;
using Employee_Management_and_Vacation_Workflow_System.RequestsOperations;
using Employee_Management_and_Vacation_Workflow_System.UpdateEmployeeMainInfo;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        EFDbContext DbContext = new EFDbContext();

        //AddInitialDepartments obj1 = new AddInitialDepartments();
        //obj1.AddDepartments(DbContext);


        //InitialPositions obj2 = new InitialPositions();
        //obj2.AddPositions(DbContext);


        //InitialEmployees obj3 = new InitialEmployees();
        //obj3.AddEmployees(DbContext);


        //UpdateEmployeeInfo obj4 = new UpdateEmployeeInfo();
        //obj4.UpdateEmployeeMainInfo(DbContext, "4", "Umar", 12, 3, 2000);


        //VacationBalance obj5 = new VacationBalance();
        //obj5.UpdateVacationDaysBalance(DbContext, 1);

        //RequestsOperations obj6 = new RequestsOperations();
        //obj6.CreateVacationRequest(DbContext, "8", "Hi, check this request out", "S", new DateOnly(2025, 6, 1), new DateOnly(2025, 6, 3));


        //ResponseToVacation obj7= new ResponseToVacation();
        //obj7.ApproveRequest(DbContext, 13);

        //GetEmployeeMainInfo obj8 = new GetEmployeeMainInfo();
        //obj8.GetEmployeeInfo(DbContext);

        //GetEmployeeByUniqueNo obj9 = new GetEmployeeByUniqueNo();
        //obj9.GetEmployeeByNo(DbContext, "8");

        //GetPendingRequests obj10 = new GetPendingRequests();
        //obj10.GetAllPendingRequests(DbContext);

        //GetApprovedRequests obj11 = new GetApprovedRequests();
        //obj11.GetAllApprovedRequests(DbContext);

        //    GetPendingForAdmin obj12 = new GetPendingForAdmin();
        //obj12.GetAllPendingRequestsForAdmins(DbContext);
    }
}
