using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blabber.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 22, 12, 797, DateTimeKind.Local).AddTicks(1832));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6177));
        }
    }
}
