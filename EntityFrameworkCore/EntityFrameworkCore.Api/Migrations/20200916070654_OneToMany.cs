using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("2041f961-fff8-4412-a80d-66fa152a6492"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("31e89c2d-ba36-461d-8b2e-be12bb9516e9"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("39d22cf1-1dc5-472c-9d6c-8cc9528d913e"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("5e813969-d695-4fb1-834d-0ebcc67e4472"));

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationId = table.Column<Guid>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    AdditionalExplanation = table.Column<string>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("7251ea7b-9240-472d-85bb-5ddf266dc09f"), 24, "Emir Balcı" },
                    { new Guid("9505643d-b637-440e-82c3-9605bb9aa37e"), 26, "Emre Balcı" },
                    { new Guid("d7ee5310-6b9d-43ed-87f3-04d71fcb97aa"), 29, "Onur Balcı" },
                    { new Guid("3d995ce6-5dc5-4930-abca-b1f51c223e0b"), 45, "Nuran Balcı" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluation",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3d995ce6-5dc5-4930-abca-b1f51c223e0b"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("7251ea7b-9240-472d-85bb-5ddf266dc09f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9505643d-b637-440e-82c3-9605bb9aa37e"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("d7ee5310-6b9d-43ed-87f3-04d71fcb97aa"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("5e813969-d695-4fb1-834d-0ebcc67e4472"), 24, "Emir Balcı" },
                    { new Guid("31e89c2d-ba36-461d-8b2e-be12bb9516e9"), 26, "Emre Balcı" },
                    { new Guid("39d22cf1-1dc5-472c-9d6c-8cc9528d913e"), 29, "Onur Balcı" },
                    { new Guid("2041f961-fff8-4412-a80d-66fa152a6492"), 45, "Nuran Balcı" }
                });
        }
    }
}
