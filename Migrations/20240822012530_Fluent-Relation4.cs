using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework2.Migrations
{
    /// <inheritdoc />
    public partial class FluentRelation4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_StudCourse",
                schema: "dbo",
                table: "StudCourse",
                columns: new[] { "StudId", "crsId" });

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_crsId",
                schema: "dbo",
                table: "StudCourse",
                column: "crsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Course_crsId",
                schema: "dbo",
                table: "StudCourse",
                column: "crsId",
                principalSchema: "dbo",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Student_StudId",
                schema: "dbo",
                table: "StudCourse",
                column: "StudId",
                principalSchema: "dbo",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Course_crsId",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Student_StudId",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudCourse",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_crsId",
                schema: "dbo",
                table: "StudCourse");
        }
    }
}
