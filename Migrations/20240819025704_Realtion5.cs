using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework2.Migrations
{
    /// <inheritdoc />
    public partial class Realtion5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                schema: "dbo",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentID",
                schema: "dbo",
                table: "Student",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Deapartment_StudentID",
                schema: "dbo",
                table: "Student",
                column: "StudentID",
                principalSchema: "dbo",
                principalTable: "Deapartment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Deapartment_StudentID",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentID",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentID",
                schema: "dbo",
                table: "Student");
        }
    }
}
