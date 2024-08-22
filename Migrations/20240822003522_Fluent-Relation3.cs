using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework2.Migrations
{
    /// <inheritdoc />
    public partial class FluentRelation3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeptId",
                schema: "dbo",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                schema: "dbo",
                table: "Instructor",
                newName: "ManagerId");

            migrationBuilder.RenameColumn(
                name: "InsId",
                schema: "dbo",
                table: "Deapartment",
                newName: "ManagerId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentId",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Deapartment_ManagerId",
                schema: "dbo",
                table: "Deapartment",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Deapartment_Instructor_ManagerId",
                schema: "dbo",
                table: "Deapartment",
                column: "ManagerId",
                principalSchema: "dbo",
                principalTable: "Instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Deapartment_DepartmentId",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Deapartment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deapartment_Instructor_ManagerId",
                schema: "dbo",
                table: "Deapartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Deapartment_DepartmentId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_DepartmentId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Deapartment_ManagerId",
                schema: "dbo",
                table: "Deapartment");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                schema: "dbo",
                table: "Instructor",
                newName: "DeptId");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                schema: "dbo",
                table: "Deapartment",
                newName: "InsId");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                schema: "dbo",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
