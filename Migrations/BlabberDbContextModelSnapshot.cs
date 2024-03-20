﻿// <auto-generated />
using System;
using Blabber;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Blabber.Migrations
{
    [DbContext(typeof(BlabberDbContext))]
    partial class BlabberDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Blabber.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "Category 1"
                        },
                        new
                        {
                            Id = 2,
                            Label = "Category 2"
                        },
                        new
                        {
                            Id = 3,
                            Label = "Category 3"
                        },
                        new
                        {
                            Id = 4,
                            Label = "Category 4"
                        });
                });

            modelBuilder.Entity("Blabber.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Content = "Comment 1 on post 1",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1209),
                            PostId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Content = "Comment 1 on post 2",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1248),
                            PostId = 2
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Content = "Comment 1 on post 3",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1250),
                            PostId = 3
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Content = "Comment 2 on post 1",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1252),
                            PostId = 1
                        });
                });

            modelBuilder.Entity("Blabber.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Approved")
                        .HasColumnType("boolean");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Approved = true,
                            CategoryId = 1,
                            Content = "Content of post 1",
                            Image = "image1.jpg",
                            PublicationDate = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1434),
                            Title = "Post 1 Title",
                            Uid = "UdGI7YhdnMdV1iH1OED135Lh7dW2",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Approved = true,
                            CategoryId = 2,
                            Content = "Content of post 2",
                            Image = "image2.jpg",
                            PublicationDate = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1439),
                            Title = "Post 2 Title",
                            Uid = "UdGI7YhdnMdV1iH1OED135Lh7dW2",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Approved = true,
                            CategoryId = 3,
                            Content = "Content of post 3",
                            Image = "image3.jpg",
                            PublicationDate = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1441),
                            Title = "Post 3 Title",
                            Uid = "ldBeWPqCOhS15JveSXB2lUqcBk63",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Approved = false,
                            CategoryId = 1,
                            Content = "Content of post 4",
                            Image = "image4.jpg",
                            PublicationDate = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1444),
                            Title = "Post 4 Title",
                            Uid = "yFykpTQFuOboizokvP1nSqgmuNi2",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Blabber.Models.Reaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Reactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "like.png",
                            Label = "Like"
                        },
                        new
                        {
                            Id = 2,
                            Image = "love.png",
                            Label = "Love"
                        },
                        new
                        {
                            Id = 3,
                            Image = "wow.png",
                            Label = "Wow"
                        },
                        new
                        {
                            Id = 4,
                            Image = "haha.png",
                            Label = "Haha"
                        });
                });

            modelBuilder.Entity("Blabber.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("EndedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("FollowerId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 2,
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1470),
                            FollowerId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1473),
                            FollowerId = 2
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 4,
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1475),
                            FollowerId = 3
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1477),
                            FollowerId = 4
                        });
                });

            modelBuilder.Entity("Blabber.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "Tag 1"
                        },
                        new
                        {
                            Id = 2,
                            Label = "Tag 2"
                        },
                        new
                        {
                            Id = 3,
                            Label = "Tag 3"
                        },
                        new
                        {
                            Id = 4,
                            Label = "Tag 4"
                        });
                });

            modelBuilder.Entity("Blabber.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsStaff")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Bio = "Bio of user 1",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1406),
                            Email = "john@example.com",
                            FirstName = "John",
                            Image = "image1.jpg",
                            IsStaff = false,
                            LastName = "Doe",
                            Uid = "user1"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Bio = "Bio of user 2",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1411),
                            Email = "jane@example.com",
                            FirstName = "Jane",
                            Image = "image2.jpg",
                            IsStaff = false,
                            LastName = "Doe",
                            Uid = "user2"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Bio = "Bio of user 3",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1413),
                            Email = "alex@example.com",
                            FirstName = "Alex",
                            Image = "image3.jpg",
                            IsStaff = false,
                            LastName = "Smith",
                            Uid = "user3"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Bio = "Bio of user 4",
                            CreatedOn = new DateTime(2024, 3, 19, 10, 27, 31, 167, DateTimeKind.Local).AddTicks(1416),
                            Email = "emily@example.com",
                            FirstName = "Emily",
                            Image = "image4.jpg",
                            IsStaff = false,
                            LastName = "Johnson",
                            Uid = "user4"
                        });
                });

            modelBuilder.Entity("PostReaction", b =>
                {
                    b.Property<int>("PostsId")
                        .HasColumnType("integer");

                    b.Property<int>("ReactionsId")
                        .HasColumnType("integer");

                    b.HasKey("PostsId", "ReactionsId");

                    b.HasIndex("ReactionsId");

                    b.ToTable("PostReaction");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostsId")
                        .HasColumnType("integer");

                    b.Property<int>("TagsId")
                        .HasColumnType("integer");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("ReactionUser", b =>
                {
                    b.Property<int>("ReactionsId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("ReactionsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ReactionUser");
                });

            modelBuilder.Entity("Blabber.Models.Category", b =>
                {
                    b.HasOne("Blabber.Models.User", null)
                        .WithMany("Categories")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Blabber.Models.Comment", b =>
                {
                    b.HasOne("Blabber.Models.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blabber.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Blabber.Models.Post", b =>
                {
                    b.HasOne("Blabber.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Blabber.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blabber.Models.Subscription", b =>
                {
                    b.HasOne("Blabber.Models.User", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Blabber.Models.Tag", b =>
                {
                    b.HasOne("Blabber.Models.User", null)
                        .WithMany("Tags")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PostReaction", b =>
                {
                    b.HasOne("Blabber.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blabber.Models.Reaction", null)
                        .WithMany()
                        .HasForeignKey("ReactionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("Blabber.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blabber.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReactionUser", b =>
                {
                    b.HasOne("Blabber.Models.Reaction", null)
                        .WithMany()
                        .HasForeignKey("ReactionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blabber.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blabber.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Blabber.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Blabber.Models.User", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("Subscriptions");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
