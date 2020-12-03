using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class changed_columnName_in_DescriptionActivite_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactFaceAFace",
                table: "DescriptionsActivite");

            migrationBuilder.AddColumn<string>(
                name: "FormOfCommunication",
                table: "DescriptionsActivite",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormOfCommunication",
                table: "DescriptionsActivite");

            migrationBuilder.AddColumn<string>(
                name: "ContactFaceAFace",
                table: "DescriptionsActivite",
                type: "text",
                nullable: true);
        }
    }
}
