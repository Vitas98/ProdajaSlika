using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdajaSlika.Migrations
{
    /// <inheritdoc />
    public partial class addedJovanAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c969f652-243e-4cf5-9122-6f8e9dd83bcb", "7c739dc7-8d36-4a90-874d-c6ed8d684529", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd96ec2c-ce12-4bb7-83fd-97781bbece06", 0, "7333a0e7-c48d-4cba-b7df-b3734bf7ccfb", "IdentityUser", "jovan@gmail.com", true, true, null, "JOVAN@GMAIL.COM", "JOVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEPDfrBagdhHhlxaBF1jemwHbCf2K5BHMiq5cRo7gkl9E1MLSJ+mDo3noi+ex5ZHSHA==", "066548165", true, "RNG3476RYQCCZPE7SUB4HKFLCN5HRQPA", false, "jovan@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c969f652-243e-4cf5-9122-6f8e9dd83bcb", "dd96ec2c-ce12-4bb7-83fd-97781bbece06" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c969f652-243e-4cf5-9122-6f8e9dd83bcb", "dd96ec2c-ce12-4bb7-83fd-97781bbece06" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c969f652-243e-4cf5-9122-6f8e9dd83bcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd96ec2c-ce12-4bb7-83fd-97781bbece06");
        }
    }
}
