using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class ManyToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    SubjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Subject");

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
                    { new Guid("7251ea7b-9240-472d-85bb-5ddf266dc09f"), 24, "Emir Balcı" },
                    { new Guid("9505643d-b637-440e-82c3-9605bb9aa37e"), 26, "Emre Balcı" },
                    { new Guid("d7ee5310-6b9d-43ed-87f3-04d71fcb97aa"), 29, "Onur Balcı" },
                    { new Guid("3d995ce6-5dc5-4930-abca-b1f51c223e0b"), 45, "Nuran Balcı" }
                });
        }
    }
}
