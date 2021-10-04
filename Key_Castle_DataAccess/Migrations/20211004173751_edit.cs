using Microsoft.EntityFrameworkCore.Migrations;

namespace Key_Castle_DataAccess.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "State",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "InquiryHeader");

            migrationBuilder.RenameColumn(
                name: "Sqft",
                table: "InquiryDetail",
                newName: "Qnty");

            migrationBuilder.RenameColumn(
                name: "PricePerSqFt",
                table: "InquiryDetail",
                newName: "PricePerQnty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Qnty",
                table: "InquiryDetail",
                newName: "Sqft");

            migrationBuilder.RenameColumn(
                name: "PricePerQnty",
                table: "InquiryDetail",
                newName: "PricePerSqFt");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
