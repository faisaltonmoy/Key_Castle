using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Key_Castle_DataAccess.Migrations
{
    public partial class header_detail_some_edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_AppUserId",
                table: "InquiryHeader");

            migrationBuilder.RenameColumn(
                name: "InquiryDate",
                table: "InquiryHeader",
                newName: "ShippingDate");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "InquiryHeader",
                newName: "CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_InquiryHeader_AppUserId",
                table: "InquiryHeader",
                newName: "IX_InquiryHeader_CreatedByUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "FinalOrderTotal",
                table: "InquiryHeader",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "InquiryHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OrderStatus",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "InquiryHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PricePerSqFt",
                table: "InquiryDetail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Sqft",
                table: "InquiryDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_CreatedByUserId",
                table: "InquiryHeader",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_CreatedByUserId",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "City",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "FinalOrderTotal",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "PaymentDate",
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

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "InquiryHeader");

            migrationBuilder.DropColumn(
                name: "PricePerSqFt",
                table: "InquiryDetail");

            migrationBuilder.DropColumn(
                name: "Sqft",
                table: "InquiryDetail");

            migrationBuilder.RenameColumn(
                name: "ShippingDate",
                table: "InquiryHeader",
                newName: "InquiryDate");

            migrationBuilder.RenameColumn(
                name: "CreatedByUserId",
                table: "InquiryHeader",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_InquiryHeader_CreatedByUserId",
                table: "InquiryHeader",
                newName: "IX_InquiryHeader_AppUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "InquiryHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_AppUserId",
                table: "InquiryHeader",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
