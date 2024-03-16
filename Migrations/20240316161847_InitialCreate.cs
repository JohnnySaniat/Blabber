using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Blabber.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    IsStaff = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReactionUser",
                columns: table => new
                {
                    ReactionsId = table.Column<int>(type: "integer", nullable: false),
                    UsersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactionUser", x => new { x.ReactionsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ReactionUser_Reactions_ReactionsId",
                        column: x => x.ReactionsId,
                        principalTable: "Reactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReactionUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FollowerId = table.Column<int>(type: "integer", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostReaction",
                columns: table => new
                {
                    PostsId = table.Column<int>(type: "integer", nullable: false),
                    ReactionsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReaction", x => new { x.PostsId, x.ReactionsId });
                    table.ForeignKey(
                        name: "FK_PostReaction_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostReaction_Reactions_ReactionsId",
                        column: x => x.ReactionsId,
                        principalTable: "Reactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostsId = table.Column<int>(type: "integer", nullable: false),
                    TagsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Label", "UserId" },
                values: new object[,]
                {
                    { 1, "Category 1", null },
                    { 2, "Category 2", null },
                    { 3, "Category 3", null },
                    { 4, "Category 4", null }
                });

            migrationBuilder.InsertData(
                table: "Reactions",
                columns: new[] { "Id", "Image", "Label" },
                values: new object[,]
                {
                    { 1, "like.png", "Like" },
                    { 2, "love.png", "Love" },
                    { 3, "wow.png", "Wow" },
                    { 4, "haha.png", "Haha" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "AuthorId", "CreatedOn", "EndedOn", "FollowerId", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6264), null, 1, null },
                    { 2, 1, new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6267), null, 2, null },
                    { 3, 4, new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6269), null, 3, null },
                    { 4, 3, new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6271), null, 4, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Label", "UserId" },
                values: new object[,]
                {
                    { 1, "Tag 1", null },
                    { 2, "Tag 2", null },
                    { 3, "Tag 3", null },
                    { 4, "Tag 4", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Bio", "CreatedOn", "Email", "FirstName", "Image", "IsStaff", "LastName", "Uid" },
                values: new object[,]
                {
                    { 1, true, "Bio of user 1", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6168), "john@example.com", "John", "image1.jpg", false, "Doe", "user1" },
                    { 2, true, "Bio of user 2", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6173), "jane@example.com", "Jane", "image2.jpg", false, "Doe", "user2" },
                    { 3, true, "Bio of user 3", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6175), "alex@example.com", "Alex", "image3.jpg", false, "Smith", "user3" },
                    { 4, true, "Bio of user 4", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6177), "emily@example.com", "Emily", "image4.jpg", false, "Johnson", "user4" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Approved", "CategoryId", "Content", "Image", "PublicationDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, true, 1, "Content of post 1", "image1.jpg", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6196), "Post 1 Title", 1 },
                    { 2, true, 2, "Content of post 2", "image2.jpg", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6200), "Post 2 Title", 2 },
                    { 3, true, 3, "Content of post 3", "image3.jpg", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6202), "Post 3 Title", 3 },
                    { 4, false, 1, "Content of post 4", "image4.jpg", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(6204), "Post 4 Title", 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedOn", "PostId" },
                values: new object[,]
                {
                    { 1, 1, "Comment 1 on post 1", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5944), 1 },
                    { 2, 2, "Comment 1 on post 2", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5991), 2 },
                    { 3, 3, "Comment 1 on post 3", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5993), 3 },
                    { 4, 4, "Comment 2 on post 1", new DateTime(2024, 3, 16, 11, 18, 47, 165, DateTimeKind.Local).AddTicks(5994), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReaction_ReactionsId",
                table: "PostReaction",
                column: "ReactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagsId",
                table: "PostTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReactionUser_UsersId",
                table: "ReactionUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_UserId",
                table: "Tags",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostReaction");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "ReactionUser");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
