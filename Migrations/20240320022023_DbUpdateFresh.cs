using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blabber.Migrations
{
    public partial class DbUpdateFresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 20, 23, 105, DateTimeKind.Local).AddTicks(8171));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 21, 5, 41, 731, DateTimeKind.Local).AddTicks(4840));
        }
    }
}
