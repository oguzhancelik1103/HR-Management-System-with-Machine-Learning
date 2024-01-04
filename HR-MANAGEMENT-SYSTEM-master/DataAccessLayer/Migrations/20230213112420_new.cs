using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonEdus_PersonEduTypes_PersonEduTypeID",
                table: "PersonEdus");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonLeaves_PersonLeaveTypes_PersonLeaveTypeID",
                table: "PersonLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonVisas_PersonVisaTypes_PersonVisaTypeID",
                table: "PersonVisas");

            migrationBuilder.DropTable(
                name: "PersonEduTypes");

            migrationBuilder.DropTable(
                name: "PersonLeaveTypes");

            migrationBuilder.DropTable(
                name: "PersonVisaTypes");

            migrationBuilder.DropIndex(
                name: "IX_SysUsers_PersonID",
                table: "SysUsers");

            migrationBuilder.DropIndex(
                name: "IX_PersonCards_PersonID",
                table: "PersonCards");

            migrationBuilder.RenameColumn(
                name: "PersonVisaTypeID",
                table: "PersonVisas",
                newName: "SysVisaTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonVisas_PersonVisaTypeID",
                table: "PersonVisas",
                newName: "IX_PersonVisas_SysVisaTypeID");

            migrationBuilder.RenameColumn(
                name: "PersonLeaveTypeID",
                table: "PersonLeaves",
                newName: "SysLeaveTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonLeaves_PersonLeaveTypeID",
                table: "PersonLeaves",
                newName: "IX_PersonLeaves_SysLeaveTypeID");

            migrationBuilder.RenameColumn(
                name: "PersonEduTypeID",
                table: "PersonEdus",
                newName: "SysEduTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonEdus_PersonEduTypeID",
                table: "PersonEdus",
                newName: "IX_PersonEdus_SysEduTypeID");

            migrationBuilder.AlterColumn<int>(
                name: "SyncID",
                table: "SysPositions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ParentID",
                table: "SysPositions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "PersonSysPosition",
                columns: table => new
                {
                    PersonsId = table.Column<int>(type: "integer", nullable: false),
                    SysPositionsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSysPosition", x => new { x.PersonsId, x.SysPositionsId });
                    table.ForeignKey(
                        name: "FK_PersonSysPosition_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonSysPosition_SysPositions_SysPositionsId",
                        column: x => x.SysPositionsId,
                        principalTable: "SysPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysDocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    MyProperty = table.Column<int>(type: "integer", nullable: false),
                    TypeID = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysEduTypes",
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
                    table.PrimaryKey("PK_SysEduTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysLeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsPaid = table.Column<short>(type: "smallint", nullable: false),
                    IsDamaged = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysLeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysVisaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysVisaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeID = table.Column<int>(type: "integer", nullable: false),
                    SysDocumentTypeId = table.Column<int>(type: "integer", nullable: false),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    LFile = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonDocuments_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonDocuments_SysDocumentTypes_SysDocumentTypeId",
                        column: x => x.SysDocumentTypeId,
                        principalTable: "SysDocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_PersonID",
                table: "SysUsers",
                column: "PersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonCards_PersonID",
                table: "PersonCards",
                column: "PersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonDocuments_PersonID",
                table: "PersonDocuments",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDocuments_SysDocumentTypeId",
                table: "PersonDocuments",
                column: "SysDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSysPosition_SysPositionsId",
                table: "PersonSysPosition",
                column: "SysPositionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonEdus_SysEduTypes_SysEduTypeID",
                table: "PersonEdus",
                column: "SysEduTypeID",
                principalTable: "SysEduTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonLeaves_SysLeaveTypes_SysLeaveTypeID",
                table: "PersonLeaves",
                column: "SysLeaveTypeID",
                principalTable: "SysLeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonVisas_SysVisaTypes_SysVisaTypeID",
                table: "PersonVisas",
                column: "SysVisaTypeID",
                principalTable: "SysVisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonEdus_SysEduTypes_SysEduTypeID",
                table: "PersonEdus");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonLeaves_SysLeaveTypes_SysLeaveTypeID",
                table: "PersonLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonVisas_SysVisaTypes_SysVisaTypeID",
                table: "PersonVisas");

            migrationBuilder.DropTable(
                name: "PersonDocuments");

            migrationBuilder.DropTable(
                name: "PersonSysPosition");

            migrationBuilder.DropTable(
                name: "SysEduTypes");

            migrationBuilder.DropTable(
                name: "SysLeaveTypes");

            migrationBuilder.DropTable(
                name: "SysVisaTypes");

            migrationBuilder.DropTable(
                name: "SysDocumentTypes");

            migrationBuilder.DropIndex(
                name: "IX_SysUsers_PersonID",
                table: "SysUsers");

            migrationBuilder.DropIndex(
                name: "IX_PersonCards_PersonID",
                table: "PersonCards");

            migrationBuilder.RenameColumn(
                name: "SysVisaTypeID",
                table: "PersonVisas",
                newName: "PersonVisaTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonVisas_SysVisaTypeID",
                table: "PersonVisas",
                newName: "IX_PersonVisas_PersonVisaTypeID");

            migrationBuilder.RenameColumn(
                name: "SysLeaveTypeID",
                table: "PersonLeaves",
                newName: "PersonLeaveTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonLeaves_SysLeaveTypeID",
                table: "PersonLeaves",
                newName: "IX_PersonLeaves_PersonLeaveTypeID");

            migrationBuilder.RenameColumn(
                name: "SysEduTypeID",
                table: "PersonEdus",
                newName: "PersonEduTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonEdus_SysEduTypeID",
                table: "PersonEdus",
                newName: "IX_PersonEdus_PersonEduTypeID");

            migrationBuilder.AlterColumn<int>(
                name: "SyncID",
                table: "SysPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentID",
                table: "SysPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PersonEduTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEduTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonLeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDamaged = table.Column<short>(type: "smallint", nullable: false),
                    IsPaid = table.Column<short>(type: "smallint", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonLeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonVisaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonVisaTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_PersonID",
                table: "SysUsers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCards_PersonID",
                table: "PersonCards",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonEdus_PersonEduTypes_PersonEduTypeID",
                table: "PersonEdus",
                column: "PersonEduTypeID",
                principalTable: "PersonEduTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonLeaves_PersonLeaveTypes_PersonLeaveTypeID",
                table: "PersonLeaves",
                column: "PersonLeaveTypeID",
                principalTable: "PersonLeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonVisas_PersonVisaTypes_PersonVisaTypeID",
                table: "PersonVisas",
                column: "PersonVisaTypeID",
                principalTable: "PersonVisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
