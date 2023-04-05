using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCBackend.Migrations
{
    /// <inheritdoc />
    public partial class ModeloInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CC_Client",
                columns: table => new
                {
                    Client_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Client_Last_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Company = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Membership = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone_No = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Client", x => x.Client_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Comerce",
                columns: table => new
                {
                    Commerce_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Commerce_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Commerce_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Comerce", x => x.Commerce_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Project_Week",
                columns: table => new
                {
                    Project_Week_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Meters_Done = table.Column<int>(type: "int", nullable: false),
                    Taks_Done = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Project_Week", x => x.Project_Week_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Rate",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Value = table.Column<int>(type: "int", nullable: true),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Rate", x => x.RateId);
                });

            migrationBuilder.CreateTable(
                name: "CC_Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Job_Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Worker",
                columns: table => new
                {
                    Worker_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Worker_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    D_O_B = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AFP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Health_Insurance = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Charges = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Payment = table.Column<float>(type: "real", nullable: false),
                    Pay_Frequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Account_Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Account_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Worker", x => x.Worker_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Project",
                columns: table => new
                {
                    Project_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Project_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Project_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Meters_To_Work = table.Column<int>(type: "int", nullable: true),
                    Meters_Worked = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Total_Value = table.Column<int>(type: "int", nullable: true),
                    Placement = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Responsible = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Related_Document = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Budget = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Spending = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Project", x => x.Project_Id);
                    table.ForeignKey(
                        name: "FK_CC_Project_CC_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "CC_Client",
                        principalColumn: "Client_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CommerceId = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Product", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_CC_Product_CC_Comerce_CommerceId",
                        column: x => x.CommerceId,
                        principalTable: "CC_Comerce",
                        principalColumn: "Commerce_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Attendance",
                columns: table => new
                {
                    Attendance_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hours_Total = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Attendance", x => x.Attendance_Id);
                    table.ForeignKey(
                        name: "FK_CC_Attendance_CC_Worker_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "CC_Worker",
                        principalColumn: "Worker_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Payments",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Payment_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Voucher = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ammount = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Payments", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK_CC_Payments_CC_Worker_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "CC_Worker",
                        principalColumn: "Worker_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Daily_Project",
                columns: table => new
                {
                    Daily_Proyect_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    Attended = table.Column<int>(type: "int", nullable: false),
                    Advancement_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Daily_Project", x => x.Daily_Proyect_Id);
                    table.ForeignKey(
                        name: "FK_CC_Daily_Project_CC_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "CC_Project",
                        principalColumn: "Project_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CC_Daily_Project_CC_Worker_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "CC_Worker",
                        principalColumn: "Worker_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Project_Entry",
                columns: table => new
                {
                    Project_Entry_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Project_Entry", x => x.Project_Entry_Id);
                    table.ForeignKey(
                        name: "FK_CC_Project_Entry_CC_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "CC_Project",
                        principalColumn: "Project_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Project_Expenditure",
                columns: table => new
                {
                    Project_Expenditure_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Project_Expenditure", x => x.Project_Expenditure_Id);
                    table.ForeignKey(
                        name: "FK_CC_Project_Expenditure_CC_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "CC_Project",
                        principalColumn: "Project_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Project_Responsible",
                columns: table => new
                {
                    Project_Responsible_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Responsible_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Responsible_Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone_No = table.Column<int>(type: "int", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Project_Responsible", x => x.Project_Responsible_Id);
                    table.ForeignKey(
                        name: "FK_CC_Project_Responsible_CC_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "CC_Project",
                        principalColumn: "Project_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Project_Task",
                columns: table => new
                {
                    Project_Taks_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Task_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Task_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaskStatus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Project_Task", x => x.Project_Taks_Id);
                    table.ForeignKey(
                        name: "FK_CC_Project_Task_CC_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "CC_Project",
                        principalColumn: "Project_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CC_Attendance_WorkerId",
                table: "CC_Attendance",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Daily_Project_ProjectId",
                table: "CC_Daily_Project",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Daily_Project_WorkerId",
                table: "CC_Daily_Project",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Payments_WorkerId",
                table: "CC_Payments",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Product_CommerceId",
                table: "CC_Product",
                column: "CommerceId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Project_ClientId",
                table: "CC_Project",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Project_Entry_ProjectId",
                table: "CC_Project_Entry",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Project_Expenditure_ProjectId",
                table: "CC_Project_Expenditure",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Project_Responsible_ProjectId",
                table: "CC_Project_Responsible",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Project_Task_ProjectId",
                table: "CC_Project_Task",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CC_Attendance");

            migrationBuilder.DropTable(
                name: "CC_Daily_Project");

            migrationBuilder.DropTable(
                name: "CC_Payments");

            migrationBuilder.DropTable(
                name: "CC_Product");

            migrationBuilder.DropTable(
                name: "CC_Project_Entry");

            migrationBuilder.DropTable(
                name: "CC_Project_Expenditure");

            migrationBuilder.DropTable(
                name: "CC_Project_Responsible");

            migrationBuilder.DropTable(
                name: "CC_Project_Task");

            migrationBuilder.DropTable(
                name: "CC_Project_Week");

            migrationBuilder.DropTable(
                name: "CC_Rate");

            migrationBuilder.DropTable(
                name: "CC_Users");

            migrationBuilder.DropTable(
                name: "CC_Worker");

            migrationBuilder.DropTable(
                name: "CC_Comerce");

            migrationBuilder.DropTable(
                name: "CC_Project");

            migrationBuilder.DropTable(
                name: "CC_Client");
        }
    }
}
