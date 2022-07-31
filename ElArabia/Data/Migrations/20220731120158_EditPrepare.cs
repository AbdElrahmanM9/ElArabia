using Microsoft.EntityFrameworkCore.Migrations;

namespace ElArabia.Data.Migrations
{
    public partial class EditPrepare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMG1",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG10",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG2",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG3",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG4",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG5",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG6",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG7",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG8",
                table: "PrepareIMG");

            migrationBuilder.DropColumn(
                name: "IMG9",
                table: "PrepareIMG");

            migrationBuilder.AddColumn<string>(
                name: "IMG",
                table: "PrepareIMG",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMG",
                table: "PrepareIMG");

            migrationBuilder.AddColumn<string>(
                name: "IMG1",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG10",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG2",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG3",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG4",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG5",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG6",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG7",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG8",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMG9",
                table: "PrepareIMG",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
