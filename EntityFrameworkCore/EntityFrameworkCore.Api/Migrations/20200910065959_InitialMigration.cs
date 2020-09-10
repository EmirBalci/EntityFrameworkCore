using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    AnotherKeyProperty = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: true),
                    IsRegularStudent = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => new { x.StudentId, x.AnotherKeyProperty });
                });

            migrationBuilder.Sql(@"CREATE PROCEDURE MyCustomProcedure AS SELECT * FROM Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
