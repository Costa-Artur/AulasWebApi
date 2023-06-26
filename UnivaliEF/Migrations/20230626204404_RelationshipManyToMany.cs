using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnivaliEF.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorCourse",
                columns: table => new
                {
                    AuthorsAuthorId = table.Column<int>(type: "integer", nullable: false),
                    CoursesCourseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorCourse", x => new { x.AuthorsAuthorId, x.CoursesCourseId });
                    table.ForeignKey(
                        name: "FK_AuthorCourse_Authors_AuthorsAuthorId",
                        column: x => x.AuthorsAuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorCourse_Courses_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorCourse_CoursesCourseId",
                table: "AuthorCourse",
                column: "CoursesCourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorCourse");
        }
    }
}
