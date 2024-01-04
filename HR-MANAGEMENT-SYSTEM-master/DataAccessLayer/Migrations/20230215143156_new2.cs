using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvCategoryInventory");

            migrationBuilder.DropTable(
                name: "PersonSocial");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "PersonLeaves",
                type: "integer",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "PersonAddresses",
                type: "integer",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.CreateTable(
                name: "InventoryConCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InventoryID = table.Column<int>(type: "integer", nullable: false),
                    InvCategoryID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryConCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryConCategories_InvCategories_InvCategoryID",
                        column: x => x.InvCategoryID,
                        principalTable: "InvCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryConCategories_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysDepartmentID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConDepartments_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConDepartments_SysDepartments_SysDepartmentID",
                        column: x => x.SysDepartmentID,
                        principalTable: "SysDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConModuleMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysModuleMenuID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConModuleMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConModuleMenus_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConModuleMenus_SysModuleMenus_SysModuleMenuID",
                        column: x => x.SysModuleMenuID,
                        principalTable: "SysModuleMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysModuleID = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConModules_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConModules_SysModules_SysModuleID",
                        column: x => x.SysModuleID,
                        principalTable: "SysModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConPerMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    PerMID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConPerMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConPerMs_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysPositionID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConPositions_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConPositions_SysPositions_SysPositionID",
                        column: x => x.SysPositionID,
                        principalTable: "SysPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConRollcallDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysDepartmentID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConRollcallDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConRollcallDepartments_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConRollcallDepartments_SysDepartments_SysDepartmentID",
                        column: x => x.SysDepartmentID,
                        principalTable: "SysDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConWorkGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    WorkGroupID = table.Column<int>(type: "integer", nullable: false),
                    SysWorkGroupId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConWorkGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConWorkGroups_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConWorkGroups_SysWorkGroups_SysWorkGroupId",
                        column: x => x.SysWorkGroupId,
                        principalTable: "SysWorkGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConWorkTemps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysWorkTempID = table.Column<int>(type: "integer", nullable: false),
                    YearSection = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConWorkTemps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConWorkTemps_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConWorkTemps_SysWorkTemps_SysWorkTempID",
                        column: x => x.SysWorkTempID,
                        principalTable: "SysWorkTemps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPeppers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    PepperSys = table.Column<short>(type: "smallint", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Lang = table.Column<string>(type: "text", nullable: false),
                    Ccheck = table.Column<short>(type: "smallint", nullable: false),
                    Scheck = table.Column<short>(type: "smallint", nullable: false),
                    Vcheck = table.Column<short>(type: "smallint", nullable: false),
                    Acheck = table.Column<short>(type: "smallint", nullable: false),
                    IMcheck = table.Column<short>(type: "smallint", nullable: false),
                    CMcheck = table.Column<short>(type: "smallint", nullable: false),
                    VMcheck = table.Column<short>(type: "smallint", nullable: false),
                    CHMcheck = table.Column<short>(type: "smallint", nullable: false),
                    SMcheck = table.Column<short>(type: "smallint", nullable: false),
                    IPcheck = table.Column<short>(type: "smallint", nullable: false),
                    WDcheck = table.Column<short>(type: "smallint", nullable: false),
                    LDProperty = table.Column<short>(type: "smallint", nullable: false),
                    IMD = table.Column<short>(type: "smallint", nullable: false),
                    CMD = table.Column<short>(type: "smallint", nullable: false),
                    VMD = table.Column<short>(type: "smallint", nullable: false),
                    CHMD = table.Column<short>(type: "smallint", nullable: false),
                    SMD = table.Column<short>(type: "smallint", nullable: false),
                    IP = table.Column<string>(type: "text", nullable: false),
                    TermID = table.Column<string>(type: "text", nullable: false),
                    WDDate = table.Column<string>(type: "text", nullable: false),
                    LDDate = table.Column<string>(type: "text", nullable: false),
                    Dashboard = table.Column<string>(type: "text", nullable: false),
                    PGManager = table.Column<string>(type: "text", nullable: false),
                    TLang = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPeppers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonPeppers_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonSocials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    CTypeID = table.Column<int>(type: "integer", nullable: false),
                    STypeID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSocials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonSocials_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysContactTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysContactTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysDemandTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDemandTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysLobbyDashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysLobbyDashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysLTransTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysLTransTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysMenuPers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysModuleMenuID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    PerKey = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysMenuPers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysRollcalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CheckedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRollcalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysRollcalls_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysRollcallStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRollcallStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysDepartmentID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    StartAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysShifts_SysDepartments_SysDepartmentID",
                        column: x => x.SysDepartmentID,
                        principalTable: "SysDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysSocialTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysSocialTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysLanguageID = table.Column<int>(type: "integer", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysTranslates_SysLanguages_SysLanguageID",
                        column: x => x.SysLanguageID,
                        principalTable: "SysLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysUserTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysUserID = table.Column<int>(type: "integer", nullable: false),
                    UserSign = table.Column<string>(type: "text", nullable: false),
                    UserToken = table.Column<string>(type: "text", nullable: false),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUserTokens_SysUsers_SysUserID",
                        column: x => x.SysUserID,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysDemands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysDemandTypeID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    StatusNote = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDemands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysDemands_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysDemands_SysDemandTypes_SysDemandTypeID",
                        column: x => x.SysDemandTypeID,
                        principalTable: "SysDemandTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConDashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    DashID = table.Column<int>(type: "integer", nullable: false),
                    SysLobbyDashboardId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConDashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConDashboards_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConDashboards_SysLobbyDashboards_SysLobbyDashboardId",
                        column: x => x.SysLobbyDashboardId,
                        principalTable: "SysLobbyDashboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonConShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysShiftID = table.Column<int>(type: "integer", nullable: false),
                    TargetedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonConShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonConShifts_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonConShifts_SysShifts_SysShiftID",
                        column: x => x.SysShiftID,
                        principalTable: "SysShifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysPersonConShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysShiftID = table.Column<int>(type: "integer", nullable: false),
                    TypeID = table.Column<short>(type: "smallint", nullable: false),
                    TargetedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysPersonConShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysPersonConShifts_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysPersonConShifts_SysShifts_SysShiftID",
                        column: x => x.SysShiftID,
                        principalTable: "SysShifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysSocials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysSocialTypeID = table.Column<int>(type: "integer", nullable: false),
                    CTypeID = table.Column<int>(type: "integer", nullable: false),
                    STypeID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysSocials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysSocials_SysSocialTypes_SysSocialTypeID",
                        column: x => x.SysSocialTypeID,
                        principalTable: "SysSocialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryConCategories_InvCategoryID",
                table: "InventoryConCategories",
                column: "InvCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryConCategories_InventoryID",
                table: "InventoryConCategories",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConDashboards_PersonID",
                table: "PersonConDashboards",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConDashboards_SysLobbyDashboardId",
                table: "PersonConDashboards",
                column: "SysLobbyDashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConDepartments_PersonID",
                table: "PersonConDepartments",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConDepartments_SysDepartmentID",
                table: "PersonConDepartments",
                column: "SysDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConModuleMenus_PersonID",
                table: "PersonConModuleMenus",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConModuleMenus_SysModuleMenuID",
                table: "PersonConModuleMenus",
                column: "SysModuleMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConModules_PersonID",
                table: "PersonConModules",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConModules_SysModuleID",
                table: "PersonConModules",
                column: "SysModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConPerMs_PersonID",
                table: "PersonConPerMs",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConPositions_PersonID",
                table: "PersonConPositions",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConPositions_SysPositionID",
                table: "PersonConPositions",
                column: "SysPositionID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConRollcallDepartments_PersonID",
                table: "PersonConRollcallDepartments",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConRollcallDepartments_SysDepartmentID",
                table: "PersonConRollcallDepartments",
                column: "SysDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConShifts_PersonID",
                table: "PersonConShifts",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConShifts_SysShiftID",
                table: "PersonConShifts",
                column: "SysShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConWorkGroups_PersonID",
                table: "PersonConWorkGroups",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConWorkGroups_SysWorkGroupId",
                table: "PersonConWorkGroups",
                column: "SysWorkGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConWorkTemps_PersonID",
                table: "PersonConWorkTemps",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonConWorkTemps_SysWorkTempID",
                table: "PersonConWorkTemps",
                column: "SysWorkTempID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPeppers_PersonID",
                table: "PersonPeppers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSocials_PersonID",
                table: "PersonSocials",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_SysDemands_PersonID",
                table: "SysDemands",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_SysDemands_SysDemandTypeID",
                table: "SysDemands",
                column: "SysDemandTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SysPersonConShifts_PersonID",
                table: "SysPersonConShifts",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_SysPersonConShifts_SysShiftID",
                table: "SysPersonConShifts",
                column: "SysShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_SysRollcalls_PersonID",
                table: "SysRollcalls",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_SysShifts_SysDepartmentID",
                table: "SysShifts",
                column: "SysDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_SysSocials_SysSocialTypeID",
                table: "SysSocials",
                column: "SysSocialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SysTranslates_SysLanguageID",
                table: "SysTranslates",
                column: "SysLanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserTokens_SysUserID",
                table: "SysUserTokens",
                column: "SysUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryConCategories");

            migrationBuilder.DropTable(
                name: "PersonConDashboards");

            migrationBuilder.DropTable(
                name: "PersonConDepartments");

            migrationBuilder.DropTable(
                name: "PersonConModuleMenus");

            migrationBuilder.DropTable(
                name: "PersonConModules");

            migrationBuilder.DropTable(
                name: "PersonConPerMs");

            migrationBuilder.DropTable(
                name: "PersonConPositions");

            migrationBuilder.DropTable(
                name: "PersonConRollcallDepartments");

            migrationBuilder.DropTable(
                name: "PersonConShifts");

            migrationBuilder.DropTable(
                name: "PersonConWorkGroups");

            migrationBuilder.DropTable(
                name: "PersonConWorkTemps");

            migrationBuilder.DropTable(
                name: "PersonPeppers");

            migrationBuilder.DropTable(
                name: "PersonSocials");

            migrationBuilder.DropTable(
                name: "SysContactTypes");

            migrationBuilder.DropTable(
                name: "SysDemands");

            migrationBuilder.DropTable(
                name: "SysLTransTypes");

            migrationBuilder.DropTable(
                name: "SysMenuPers");

            migrationBuilder.DropTable(
                name: "SysPersonConShifts");

            migrationBuilder.DropTable(
                name: "SysRollcalls");

            migrationBuilder.DropTable(
                name: "SysRollcallStatuses");

            migrationBuilder.DropTable(
                name: "SysSocials");

            migrationBuilder.DropTable(
                name: "SysTranslates");

            migrationBuilder.DropTable(
                name: "SysUserTokens");

            migrationBuilder.DropTable(
                name: "SysLobbyDashboards");

            migrationBuilder.DropTable(
                name: "SysDemandTypes");

            migrationBuilder.DropTable(
                name: "SysShifts");

            migrationBuilder.DropTable(
                name: "SysSocialTypes");

            migrationBuilder.AlterColumn<short>(
                name: "Status",
                table: "PersonLeaves",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<short>(
                name: "Status",
                table: "PersonAddresses",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "InvCategoryInventory",
                columns: table => new
                {
                    InvCategoriesId = table.Column<int>(type: "integer", nullable: false),
                    InventoriesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvCategoryInventory", x => new { x.InvCategoriesId, x.InventoriesId });
                    table.ForeignKey(
                        name: "FK_InvCategoryInventory_InvCategories_InvCategoriesId",
                        column: x => x.InvCategoriesId,
                        principalTable: "InvCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvCategoryInventory_Inventories_InventoriesId",
                        column: x => x.InventoriesId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonSocial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    CTypeID = table.Column<short>(type: "smallint", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    STypeID = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonSocial_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvCategoryInventory_InventoriesId",
                table: "InvCategoryInventory",
                column: "InventoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSocial_PersonID",
                table: "PersonSocial",
                column: "PersonID");
        }
    }
}
