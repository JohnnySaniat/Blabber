using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blabber.Migrations
{
    public partial class JCSUid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Posts",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "PublicationDate", "Uid" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1434), "UdGI7YhdnMdV1iH1OED135Lh7dW2" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublicationDate", "Uid" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1439), "UdGI7YhdnMdV1iH1OED135Lh7dW2" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublicationDate", "Uid" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1441), "ldBeWPqCOhS15JveSXB2lUqcBk63" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublicationDate", "Uid" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1444), "yFykpTQFuOboizokvP1nSqgmuNi2" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Posts");

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
