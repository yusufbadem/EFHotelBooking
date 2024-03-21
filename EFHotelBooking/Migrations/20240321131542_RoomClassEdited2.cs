using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFHotelBooking.Migrations
{
    /// <inheritdoc />
    public partial class RoomClassEdited2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailabla",
                table: "Rooms",
                newName: "IsAvailable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Rooms",
                newName: "IsAvailabla");
        }
    }
}
