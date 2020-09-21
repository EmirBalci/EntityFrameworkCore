using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class StudentEvaluationRestrictDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("396c00be-5330-44f7-96fe-382aa8e15972"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c5d97b17-a17f-4d57-8d69-20b257fad8ff"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("d57b3e34-00b8-4f56-86e9-e5df2b34199a"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("db50c140-d87e-480b-b2fb-ca8612c69f91"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("a50873df-a369-44f0-bf34-2983dc5d104d"), 24, "Emir Balcı" },
                    { new Guid("a71b80db-72d0-4c62-a247-fa7d0b5b78b6"), 26, "Emre Balcı" },
                    { new Guid("72bb74a0-a43f-4619-8283-ebc48cb7e4bd"), 29, "Onur Balcı" },
                    { new Guid("10876715-1f34-40ec-b8ac-1ef56d593cf8"), 45, "Nuran Balcı" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("10876715-1f34-40ec-b8ac-1ef56d593cf8"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("72bb74a0-a43f-4619-8283-ebc48cb7e4bd"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a50873df-a369-44f0-bf34-2983dc5d104d"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a71b80db-72d0-4c62-a247-fa7d0b5b78b6"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("396c00be-5330-44f7-96fe-382aa8e15972"), 24, "Emir Balcı" },
                    { new Guid("d57b3e34-00b8-4f56-86e9-e5df2b34199a"), 26, "Emre Balcı" },
                    { new Guid("db50c140-d87e-480b-b2fb-ca8612c69f91"), 29, "Onur Balcı" },
                    { new Guid("c5d97b17-a17f-4d57-8d69-20b257fad8ff"), 45, "Nuran Balcı" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
