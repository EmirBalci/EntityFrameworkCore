using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class AdditionalRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("8d3a93b7-a903-41dc-bddc-68e08a8393d9"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("b49e754e-bd5b-4173-8b09-9d2ae69bdd44"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.AlterColumn<bool>(
                name: "IsRegularStudent",
                table: "Student",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[] { new Guid("22b0456a-2daa-4635-8aa3-8442e03e4af6"), 24, new Guid("00000000-0000-0000-0000-000000000000"), "Emir Balcı" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[] { new Guid("b0642811-1f03-4154-aacf-185374a194e0"), 26, new Guid("00000000-0000-0000-0000-000000000000"), "Emre Balcı" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[] { new Guid("4c04b1ea-42ee-43af-9507-2f78f2fa8568"), 29, new Guid("00000000-0000-0000-0000-000000000000"), "Onur Balcı" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("22b0456a-2daa-4635-8aa3-8442e03e4af6"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("4c04b1ea-42ee-43af-9507-2f78f2fa8568"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("b0642811-1f03-4154-aacf-185374a194e0"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsRegularStudent",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("b49e754e-bd5b-4173-8b09-9d2ae69bdd44"), new Guid("00000000-0000-0000-0000-000000000000"), 24, "Emir Balcı" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("8d3a93b7-a903-41dc-bddc-68e08a8393d9"), new Guid("00000000-0000-0000-0000-000000000000"), 27, "Emre Balcı" });
        }
    }
}
