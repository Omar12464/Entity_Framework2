using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework2.Migrations
{
    /// <inheritdoc />
    public partial class Realtion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                schema: "dbo",
                table: "Student",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Student",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Cairo",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "20, 20")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Instructor",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                schema: "dbo",
                table: "Instructor",
                type: "money",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Deapartment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: true),
                    HiringDate = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<int>(type: "int", nullable: false, computedColumnSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deapartment", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Deapartment_InsId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropTable(
                name: "Deapartment",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_InsId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "DeptId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "InsId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                schema: "dbo",
                table: "Student",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Student",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Cairo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "20, 20");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Instructor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<int>(
                name: "Bonus",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddColumn<int>(
                name: "DepId",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
