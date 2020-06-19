using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw7.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Zamowienie_WyrobCukierniczies",
                columns: new[] { "IdWyrobuCukierniczego", "IdZamowienia", "Ilosc", "Uwagi" },
                values: new object[] { 2, 1, 2, "zamowiony na przyjecie urodzinowe" });

            migrationBuilder.UpdateData(
                table: "Zamowienies",
                keyColumn: "IdZamowienia",
                keyValue: 1,
                column: "DataPrzyjecia",
                value: new DateTime(2020, 6, 19, 9, 15, 50, 379, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Zamowienies",
                keyColumn: "IdZamowienia",
                keyValue: 2,
                column: "DataPrzyjecia",
                value: new DateTime(2020, 6, 19, 9, 15, 50, 383, DateTimeKind.Local).AddTicks(3209));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczies",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Zamowienies",
                keyColumn: "IdZamowienia",
                keyValue: 1,
                column: "DataPrzyjecia",
                value: new DateTime(2020, 6, 19, 8, 55, 54, 262, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Zamowienies",
                keyColumn: "IdZamowienia",
                keyValue: 2,
                column: "DataPrzyjecia",
                value: new DateTime(2020, 6, 19, 8, 55, 54, 267, DateTimeKind.Local).AddTicks(976));
        }
    }
}
