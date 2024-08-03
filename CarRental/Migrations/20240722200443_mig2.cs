using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DropOffLocationName",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "PickupLocationName",
                table: "Locations",
                newName: "LocationName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LocationName",
                table: "Locations",
                newName: "PickupLocationName");

            migrationBuilder.AddColumn<string>(
                name: "DropOffLocationName",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
