using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LittleShipManagementSystemData.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_HoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_HoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Load",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Load", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Captain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsOnTheWay = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Captain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Captain_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsOnTheWay = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Worker_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShipNationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAge = table.Column<int>(type: "int", nullable: false),
                    IsOnTheWay = table.Column<bool>(type: "bit", nullable: false),
                    ShipCompanyId = table.Column<int>(type: "int", nullable: false),
                    CurrentDockId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ship_Company_ShipCompanyId",
                        column: x => x.ShipCompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ship_Dock_CurrentDockId",
                        column: x => x.CurrentDockId,
                        principalTable: "Dock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Container",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeightType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContainerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightAmount = table.Column<int>(type: "int", nullable: false),
                    LoadId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Container", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Container_Load_LoadId",
                        column: x => x.LoadId,
                        principalTable: "Load",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Journey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDockId = table.Column<int>(type: "int", nullable: false),
                    EndDockId = table.Column<int>(type: "int", nullable: false),
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    CaptainId = table.Column<int>(type: "int", nullable: false),
                    GuessedJourneyTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Journey_Captain_CaptainId",
                        column: x => x.CaptainId,
                        principalTable: "Captain",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Journey_Dock_EndDockId",
                        column: x => x.EndDockId,
                        principalTable: "Dock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Journey_Dock_StartDockId",
                        column: x => x.StartDockId,
                        principalTable: "Dock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Journey_Ship_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ship",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JourneyId = table.Column<int>(type: "int", nullable: false),
                    Fee_MoneyNationalityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee_MoneyAmount = table.Column<int>(type: "int", nullable: false),
                    CustomerCompanyId = table.Column<int>(type: "int", nullable: false),
                    ShipLogisticCompanyId = table.Column<int>(type: "int", nullable: false),
                    LoadId = table.Column<int>(type: "int", nullable: false),
                    IsContractCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_Company_CustomerCompanyId",
                        column: x => x.CustomerCompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Company_ShipLogisticCompanyId",
                        column: x => x.ShipLogisticCompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Journey_JourneyId",
                        column: x => x.JourneyId,
                        principalTable: "Journey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contract_Load_LoadId",
                        column: x => x.LoadId,
                        principalTable: "Load",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JourneyWorker",
                columns: table => new
                {
                    JourneysId = table.Column<int>(type: "int", nullable: false),
                    WorkersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JourneyWorker", x => new { x.JourneysId, x.WorkersId });
                    table.ForeignKey(
                        name: "FK_JourneyWorker_Journey_JourneysId",
                        column: x => x.JourneysId,
                        principalTable: "Journey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JourneyWorker_Worker_WorkersId",
                        column: x => x.WorkersId,
                        principalTable: "Worker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.Id);

                    table.ForeignKey(
                        name: "FK_Receipt_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Captain_CompanyId",
                table: "Captain",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Container_LoadId",
                table: "Container",
                column: "LoadId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_CustomerCompanyId",
                table: "Contract",
                column: "CustomerCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_JourneyId",
                table: "Contract",
                column: "JourneyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contract_LoadId",
                table: "Contract",
                column: "LoadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ShipLogisticCompanyId",
                table: "Contract",
                column: "ShipLogisticCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Journey_CaptainId",
                table: "Journey",
                column: "CaptainId");

            migrationBuilder.CreateIndex(
                name: "IX_Journey_EndDockId",
                table: "Journey",
                column: "EndDockId");

            migrationBuilder.CreateIndex(
                name: "IX_Journey_ShipId",
                table: "Journey",
                column: "ShipId");

            migrationBuilder.CreateIndex(
                name: "IX_Journey_StartDockId",
                table: "Journey",
                column: "StartDockId");

            migrationBuilder.CreateIndex(
                name: "IX_JourneyWorker_WorkersId",
                table: "JourneyWorker",
                column: "WorkersId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ContractId",
                table: "Receipt",
                column: "ContractId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ship_CurrentDockId",
                table: "Ship",
                column: "CurrentDockId");

            migrationBuilder.CreateIndex(
                name: "IX_Ship_ShipCompanyId",
                table: "Ship",
                column: "ShipCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Worker_CompanyId",
                table: "Worker",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Container");

            migrationBuilder.DropTable(
                name: "JourneyWorker");

            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "Worker");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Journey");

            migrationBuilder.DropTable(
                name: "Load");

            migrationBuilder.DropTable(
                name: "Captain");

            migrationBuilder.DropTable(
                name: "Ship");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Dock");
        }
    }
}