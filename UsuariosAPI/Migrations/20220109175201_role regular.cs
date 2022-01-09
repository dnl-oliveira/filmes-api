using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class roleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0a0b57c4-5e53-40e9-a414-155f4c12d709");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "45336ba1-a8e5-4bff-bb76-7a932b063975", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b1c86c4-f584-41d0-9f6c-1daccd5840db", "AQAAAAEAACcQAAAAEKsorui5sY8E3XOSYcHrCp0yuSEw95iH4p2eltPMfVNxE2HBBFTHeZv1mxx5dFoK3g==", "387293e7-6cc7-4745-969b-80df07839897" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "5355f6b6-9b87-4f40-885a-d8937d1b082a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43223600-9a6a-4285-8c8f-062f9173791c", "AQAAAAEAACcQAAAAEDx5yIh5QWnliuWFlPSkMTk2DjSKpxOwxnfORV9XHuzBQAH7Np95MiFILZ22QJJd9A==", "7dc75624-feb6-4078-b023-d9a643624dd7" });
        }
    }
}
