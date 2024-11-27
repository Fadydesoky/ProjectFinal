using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttendanceSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Learners");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "SessionLogs",
                newName: "SessionDate");

            migrationBuilder.AddColumn<string>(
                name: "SessionDetails",
                table: "SessionLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Learners",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionDetails",
                table: "SessionLogs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Learners");

            migrationBuilder.RenameColumn(
                name: "SessionDate",
                table: "SessionLogs",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Learners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
