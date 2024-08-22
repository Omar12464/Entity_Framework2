using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework2.Migrations
{
    /// <inheritdoc />
    public partial class FluentRelation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Deapartment_InsId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_InsId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "InsId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Topic",
                newName: "Top_Id");

            migrationBuilder.RenameColumn(
                name: "DepId",
                schema: "dbo",
                table: "Student",
                newName: "DeptId");

            migrationBuilder.RenameColumn(
                name: "TopId",
                schema: "dbo",
                table: "Course",
                newName: "TopicId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                schema: "dbo",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_DepartmentId",
                schema: "dbo",
                table: "Student",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TopicId",
                schema: "dbo",
                table: "Course",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_TopicId",
                schema: "dbo",
                table: "Course",
                column: "TopicId",
                principalSchema: "dbo",
                principalTable: "Topic",
                principalColumn: "Top_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Deapartment_DepartmentId",
                schema: "dbo",
                table: "Student",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Deapartment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_TopicId",
                schema: "dbo",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Deapartment_DepartmentId",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_DepartmentId",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Course_TopicId",
                schema: "dbo",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                schema: "dbo",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Top_Id",
                schema: "dbo",
                table: "Topic",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                schema: "dbo",
                table: "Student",
                newName: "DepId");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                schema: "dbo",
                table: "Course",
                newName: "TopId");

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_InsId",
                schema: "dbo",
                table: "Instructor",
                column: "InsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Deapartment_InsId",
                schema: "dbo",
                table: "Instructor",
                column: "InsId",
                principalSchema: "dbo",
                principalTable: "Deapartment",
                principalColumn: "Id");
        }
    }
}
