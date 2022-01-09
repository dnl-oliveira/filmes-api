using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class adicionandocustomIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "3742b76a-9ed7-4722-9e95-6f8e9d80d1f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0b688dd6-76db-4234-b223-e7a7788cff8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5163633-a448-445e-97f7-98f15237ad08", "AQAAAAEAACcQAAAAEOAICPhcANZ4MrxUdT6rd98841g3Whzy8SQXXgIO7kxHN1ODMbzJY0gmFNfOkKuM0Q==", "87ab6e77-b9d1-4fc9-9366-2dac2cc825be" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "45336ba1-a8e5-4bff-bb76-7a932b063975");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0a0b57c4-5e53-40e9-a414-155f4c12d709");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b1c86c4-f584-41d0-9f6c-1daccd5840db", "AQAAAAEAACcQAAAAEKsorui5sY8E3XOSYcHrCp0yuSEw95iH4p2eltPMfVNxE2HBBFTHeZv1mxx5dFoK3g==", "387293e7-6cc7-4745-969b-80df07839897" });
        }
    }
}
