using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MMBlog.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InstanceMeraksDbNameUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__instanceMeraks",
                table: "_instanceMeraks");

            migrationBuilder.RenameTable(
                name: "_instanceMeraks",
                newName: "InstanceMeraks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstanceMeraks",
                table: "InstanceMeraks",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InstanceMeraks",
                table: "InstanceMeraks");

            migrationBuilder.RenameTable(
                name: "InstanceMeraks",
                newName: "_instanceMeraks");

            migrationBuilder.AddPrimaryKey(
                name: "PK__instanceMeraks",
                table: "_instanceMeraks",
                column: "Id");
        }
    }
}
