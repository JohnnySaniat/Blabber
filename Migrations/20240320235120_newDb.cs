using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blabber.Migrations
{
    public partial class newDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 18, 51, 19, 240, DateTimeKind.Local).AddTicks(6510));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1416));
        }
    }
}
