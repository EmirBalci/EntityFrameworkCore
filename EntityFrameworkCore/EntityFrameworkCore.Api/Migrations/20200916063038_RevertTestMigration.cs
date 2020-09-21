using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class RevertTestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("1829f0e8-4866-41ab-b34b-e85c1de147a2"), 24, new Guid("00000000-0000-0000-0000-000000000000"), "Emir Balcı" },
                    { new Guid("961c5226-dbda-4519-a55f-0dc493400acc"), 26, new Guid("00000000-0000-0000-0000-000000000000"), "Emre Balcı" },
                    { new Guid("e31a0b04-a3ad-4de2-8907-e1e4eec4cc5f"), 29, new Guid("00000000-0000-0000-0000-000000000000"), "Onur Balcı" },
                    { new Guid("4d24d022-47e6-46d8-86cc-bb287392ef60"), 45, new Guid("00000000-0000-0000-0000-000000000000"), "Nuran Balcı" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1829f0e8-4866-41ab-b34b-e85c1de147a2"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("4d24d022-47e6-46d8-86cc-bb287392ef60"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("961c5226-dbda-4519-a55f-0dc493400acc"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("e31a0b04-a3ad-4de2-8907-e1e4eec4cc5f"));

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
    }
}
