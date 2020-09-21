using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("b49e754e-bd5b-4173-8b09-9d2ae69bdd44"), new Guid("00000000-0000-0000-0000-000000000000"), 24, "Emir Balcı" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("8d3a93b7-a903-41dc-bddc-68e08a8393d9"), new Guid("00000000-0000-0000-0000-000000000000"), 27, "Emre Balcı" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("8d3a93b7-a903-41dc-bddc-68e08a8393d9"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("b49e754e-bd5b-4173-8b09-9d2ae69bdd44"), new Guid("00000000-0000-0000-0000-000000000000") });
        }
    }
}
