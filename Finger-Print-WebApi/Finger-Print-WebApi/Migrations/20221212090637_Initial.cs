using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FingerPrintWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startdate = table.Column<DateTime>(name: "start_date", type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ptypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ptypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authority = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    milataryservicestatus = table.Column<string>(name: "milatary_service_status", type: "nvarchar(max)", nullable: false),
                    nationalid = table.Column<string>(name: "national_id", type: "nvarchar(max)", nullable: false),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    government = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    martialstatus = table.Column<string>(name: "martial_status", type: "nvarchar(max)", nullable: false),
                    numchildren = table.Column<int>(name: "num_children", type: "int", nullable: false),
                    socialinsurance = table.Column<string>(name: "social_insurance", type: "nvarchar(max)", nullable: false),
                    phonenumber = table.Column<string>(name: "phone_number", type: "nvarchar(max)", nullable: false),
                    religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobdescription = table.Column<string>(name: "job_description", type: "nvarchar(max)", nullable: false),
                    photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Deptid = table.Column<int>(name: "Dept_id", type: "int", nullable: false),
                    Contractid = table.Column<int>(name: "Contract_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Contracts_Contract_id",
                        column: x => x.Contractid,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Dept_id",
                        column: x => x.Deptid,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    intime = table.Column<TimeSpan>(name: "in_time", type: "time", nullable: false),
                    outtime = table.Column<TimeSpan>(name: "out_time", type: "time", nullable: false),
                    Employeeid = table.Column<int>(name: "Employee_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.id);
                    table.ForeignKey(
                        name: "FK_Attendances_Employees_Employee_id",
                        column: x => x.Employeeid,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    allowance = table.Column<int>(type: "int", nullable: false),
                    startdate = table.Column<DateTime>(name: "start_date", type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "datetime2", nullable: false),
                    Employeeid = table.Column<int>(name: "Employee_id", type: "int", nullable: false),
                    Mtypeid = table.Column<int>(name: "Mtype_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Missions_Employees_Employee_id",
                        column: x => x.Employeeid,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Missions_Mtypes_Mtype_id",
                        column: x => x.Mtypeid,
                        principalTable: "Mtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    time = table.Column<TimeSpan>(type: "time", nullable: false),
                    number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employeeid = table.Column<int>(name: "Employee_id", type: "int", nullable: false),
                    Ptypeid = table.Column<int>(name: "Ptype_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Employees_Employee_id",
                        column: x => x.Employeeid,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_Ptypes_Ptype_id",
                        column: x => x.Ptypeid,
                        principalTable: "Ptypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startdate = table.Column<DateTime>(name: "start_date", type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "datetime2", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employeeid = table.Column<int>(name: "Employee_id", type: "int", nullable: false),
                    VTypeid = table.Column<int>(name: "VType_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations_Employees_Employee_id",
                        column: x => x.Employeeid,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacations_Vtypes_VType_id",
                        column: x => x.VTypeid,
                        principalTable: "Vtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_Employee_id",
                table: "Attendances",
                column: "Employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Contract_id",
                table: "Employees",
                column: "Contract_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Dept_id",
                table: "Employees",
                column: "Dept_id");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_Employee_id",
                table: "Missions",
                column: "Employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_Mtype_id",
                table: "Missions",
                column: "Mtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_Employee_id",
                table: "Permissions",
                column: "Employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_Ptype_id",
                table: "Permissions",
                column: "Ptype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_Employee_id",
                table: "Vacations",
                column: "Employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_VType_id",
                table: "Vacations",
                column: "VType_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "Mtypes");

            migrationBuilder.DropTable(
                name: "Ptypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Vtypes");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
