using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blabber.Migrations
{
    public partial class newCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 9, 44, 6, 341, DateTimeKind.Local).AddTicks(8150));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
