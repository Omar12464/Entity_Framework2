using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework2.Migrations
{
    /// <inheritdoc />
    public partial class Realtion4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TopId",
                schema: "dbo",
                table: "Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                schema: "dbo",
                table: "Course",
                type: "int",
                nullable: true);

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
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_TopicId",
                schema: "dbo",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_TopicId",
                schema: "dbo",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "TopicId",
                schema: "dbo",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "TopId",
                schema: "dbo",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
