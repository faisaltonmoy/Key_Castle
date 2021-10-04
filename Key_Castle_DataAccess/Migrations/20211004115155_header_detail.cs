using Microsoft.EntityFrameworkCore.Migrations;

namespace Key_Castle_DataAccess.Migrations
{
    public partial class header_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_ApplicationUserId",
                table: "InquiryHeader");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "InquiryHeader",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_InquiryHeader_ApplicationUserId",
                table: "InquiryHeader",
                newName: "IX_InquiryHeader_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_AppUserId",
                table: "InquiryHeader",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_AppUserId",
                table: "InquiryHeader");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "InquiryHeader",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_InquiryHeader_AppUserId",
                table: "InquiryHeader",
                newName: "IX_InquiryHeader_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InquiryHeader_AspNetUsers_ApplicationUserId",
                table: "InquiryHeader",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
