using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework2.Migrations
{
    /// <inheritdoc />
    public partial class FluentRelation5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                schema: "dbo",
                table: "Course_Inst",
                columns: new[] { "CrsId", "InstId" });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_InstId",
                schema: "dbo",
                table: "Course_Inst",
                column: "InstId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Course_CrsId",
                schema: "dbo",
                table: "Course_Inst",
                column: "CrsId",
                principalSchema: "dbo",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructor_InstId",
                schema: "dbo",
                table: "Course_Inst",
                column: "InstId",
                principalSchema: "dbo",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Course_CrsId",
                schema: "dbo",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructor_InstId",
                schema: "dbo",
                table: "Course_Inst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                schema: "dbo",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_InstId",
                schema: "dbo",
                table: "Course_Inst");
        }
    }
}
