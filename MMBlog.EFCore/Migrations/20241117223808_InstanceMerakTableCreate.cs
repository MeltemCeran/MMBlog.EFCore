using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MMBlog.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InstanceMerakTableCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__page6AllQAs",
                table: "_page6AllQAs");

            migrationBuilder.DropPrimaryKey(
                name: "PK__page3CheckBoxes",
                table: "_page3CheckBoxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__myTODOs",
                table: "_myTODOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK__musicList",
                table: "_musicList");

            migrationBuilder.RenameTable(
                name: "_page6AllQAs",
                newName: "Page6AllQAs");

            migrationBuilder.RenameTable(
                name: "_page3CheckBoxes",
                newName: "Page3CheckBoxes");

            migrationBuilder.RenameTable(
                name: "_myTODOs",
                newName: "MyTODOs");

            migrationBuilder.RenameTable(
                name: "_musicList",
                newName: "MusicLists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Page6AllQAs",
                table: "Page6AllQAs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Page3CheckBoxes",
                table: "Page3CheckBoxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyTODOs",
                table: "MyTODOs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicLists",
                table: "MusicLists",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "_instanceMeraks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerakName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSolved = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__instanceMeraks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_instanceMeraks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Page6AllQAs",
                table: "Page6AllQAs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Page3CheckBoxes",
                table: "Page3CheckBoxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyTODOs",
                table: "MyTODOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicLists",
                table: "MusicLists");

            migrationBuilder.RenameTable(
                name: "Page6AllQAs",
                newName: "_page6AllQAs");

            migrationBuilder.RenameTable(
                name: "Page3CheckBoxes",
                newName: "_page3CheckBoxes");

            migrationBuilder.RenameTable(
                name: "MyTODOs",
                newName: "_myTODOs");

            migrationBuilder.RenameTable(
                name: "MusicLists",
                newName: "_musicList");

            migrationBuilder.AddPrimaryKey(
                name: "PK__page6AllQAs",
                table: "_page6AllQAs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__page3CheckBoxes",
                table: "_page3CheckBoxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__myTODOs",
                table: "_myTODOs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__musicList",
                table: "_musicList",
                column: "Id");
        }
    }
}
