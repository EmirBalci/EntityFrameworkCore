using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Api.Migrations
{
    public partial class OneToOneRelationshipStudent_StudentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AnotherKeyProperty",
                table: "Student");

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentDetailsId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AdditionalInformation = table.Column<string>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentDetailsId);
                    table.ForeignKey(
                        name: "FK_StudentDetails_Student_StudentId",
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
                    { new Guid("5e813969-d695-4fb1-834d-0ebcc67e4472"), 24, "Emir Balcı" },
                    { new Guid("31e89c2d-ba36-461d-8b2e-be12bb9516e9"), 26, "Emre Balcı" },
                    { new Guid("39d22cf1-1dc5-472c-9d6c-8cc9528d913e"), 29, "Onur Balcı" },
                    { new Guid("2041f961-fff8-4412-a80d-66fa152a6492"), 45, "Nuran Balcı" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_StudentId",
                table: "StudentDetails",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetails");

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

            migrationBuilder.AddColumn<Guid>(
                name: "AnotherKeyProperty",
                table: "Student",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
