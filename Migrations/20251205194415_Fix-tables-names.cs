using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Management_and_Vacation_Workflow_System.Migrations
{
    /// <inheritdoc />
    public partial class Fixtablesnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Position_PositionId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequest_Employee_EmployeeNumber",
                table: "VacationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequest_RequestState_RequestStateID",
                table: "VacationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequest_VacationType_VacationTypeId",
                table: "VacationRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationType",
                table: "VacationType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationRequest",
                table: "VacationRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestState",
                table: "RequestState");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Position",
                table: "Position");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "VacationType",
                newName: "VacationTypes");

            migrationBuilder.RenameTable(
                name: "VacationRequest",
                newName: "VacationRequests");

            migrationBuilder.RenameTable(
                name: "RequestState",
                newName: "RequestStates");

            migrationBuilder.RenameTable(
                name: "Position",
                newName: "Positions");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_VacationRequest_VacationTypeId",
                table: "VacationRequests",
                newName: "IX_VacationRequests_VacationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VacationRequest_RequestStateID",
                table: "VacationRequests",
                newName: "IX_VacationRequests_RequestStateID");

            migrationBuilder.RenameIndex(
                name: "IX_VacationRequest_EmployeeNumber",
                table: "VacationRequests",
                newName: "IX_VacationRequests_EmployeeNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_PositionId",
                table: "Employees",
                newName: "IX_Employees_PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employees",
                newName: "IX_Employees_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationTypes",
                table: "VacationTypes",
                column: "VacationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationRequests",
                table: "VacationRequests",
                column: "RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestStates",
                table: "RequestStates",
                column: "StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequests_Employees_EmployeeNumber",
                table: "VacationRequests",
                column: "EmployeeNumber",
                principalTable: "Employees",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequests_RequestStates_RequestStateID",
                table: "VacationRequests",
                column: "RequestStateID",
                principalTable: "RequestStates",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequests_VacationTypes_VacationTypeId",
                table: "VacationRequests",
                column: "VacationTypeId",
                principalTable: "VacationTypes",
                principalColumn: "VacationTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequests_Employees_EmployeeNumber",
                table: "VacationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequests_RequestStates_RequestStateID",
                table: "VacationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequests_VacationTypes_VacationTypeId",
                table: "VacationRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationTypes",
                table: "VacationTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationRequests",
                table: "VacationRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestStates",
                table: "RequestStates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "VacationTypes",
                newName: "VacationType");

            migrationBuilder.RenameTable(
                name: "VacationRequests",
                newName: "VacationRequest");

            migrationBuilder.RenameTable(
                name: "RequestStates",
                newName: "RequestState");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "Position");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_VacationRequests_VacationTypeId",
                table: "VacationRequest",
                newName: "IX_VacationRequest_VacationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VacationRequests_RequestStateID",
                table: "VacationRequest",
                newName: "IX_VacationRequest_RequestStateID");

            migrationBuilder.RenameIndex(
                name: "IX_VacationRequests_EmployeeNumber",
                table: "VacationRequest",
                newName: "IX_VacationRequest_EmployeeNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PositionId",
                table: "Employee",
                newName: "IX_Employee_PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employee",
                newName: "IX_Employee_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationType",
                table: "VacationType",
                column: "VacationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationRequest",
                table: "VacationRequest",
                column: "RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestState",
                table: "RequestState",
                column: "StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Position",
                table: "Position",
                column: "PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Position_PositionId",
                table: "Employee",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequest_Employee_EmployeeNumber",
                table: "VacationRequest",
                column: "EmployeeNumber",
                principalTable: "Employee",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequest_RequestState_RequestStateID",
                table: "VacationRequest",
                column: "RequestStateID",
                principalTable: "RequestState",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequest_VacationType_VacationTypeId",
                table: "VacationRequest",
                column: "VacationTypeId",
                principalTable: "VacationType",
                principalColumn: "VacationTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
