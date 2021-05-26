using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagementSystem.Migrations
{
    public partial class vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DepatureTime",
                table: "Vehicles");

            migrationBuilder.AddColumn<DateTime>(
                name: "EveningShiftArrivalTime",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EveningShiftDepatureTime",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MorningShiftArrivalTime",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MorningShiftDepatureTime",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EveningShiftArrivalTime",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EveningShiftDepatureTime",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MorningShiftArrivalTime",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MorningShiftDepatureTime",
                table: "Vehicles");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DepatureTime",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "char(10)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
