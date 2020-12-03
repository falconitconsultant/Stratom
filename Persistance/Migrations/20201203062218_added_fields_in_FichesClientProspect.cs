using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class added_fields_in_FichesClientProspect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactTelephone",
                table: "DescriptionsActivite");

            migrationBuilder.AddColumn<string>(
                name: "ContratsAnnualSubscription",
                table: "FichesClientProspect",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContratsDateSouscription",
                table: "FichesClientProspect",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ContratsGarantie",
                table: "FichesClientProspect",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContratsType",
                table: "FichesClientProspect",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContratsAnnualSubscription",
                table: "FichesClientProspect");

            migrationBuilder.DropColumn(
                name: "ContratsDateSouscription",
                table: "FichesClientProspect");

            migrationBuilder.DropColumn(
                name: "ContratsGarantie",
                table: "FichesClientProspect");

            migrationBuilder.DropColumn(
                name: "ContratsType",
                table: "FichesClientProspect");

            migrationBuilder.AddColumn<string>(
                name: "ContactTelephone",
                table: "DescriptionsActivite",
                type: "text",
                nullable: true);
        }
    }
}
