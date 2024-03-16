using Microsoft.EntityFrameworkCore;
using Blabber.Models;

namespace Blabber
{
    public class BlabberDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        public BlabberDbContext(DbContextOptions<BlabberDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(new Comment[]
            {
                new Comment { Id = 1, AuthorId = 1, PostId = 1, Content = "Comment 1 on post 1", CreatedOn = DateTime.Now },
                new Comment { Id = 2, AuthorId = 2, PostId = 2, Content = "Comment 1 on post 2", CreatedOn = DateTime.Now },
                new Comment { Id = 3, AuthorId = 3, PostId = 3, Content = "Comment 1 on post 3", CreatedOn = DateTime.Now },
                new Comment { Id = 4, AuthorId = 4, PostId = 1, Content = "Comment 2 on post 1", CreatedOn = DateTime.Now }
            });

            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User { Id = 1, FirstName = "John", LastName = "Doe", Bio = "Bio of user 1", Image = "image1.jpg", Email = "john@example.com", CreatedOn = DateTime.Now, Active = true, IsStaff = false, Uid = "user1" },
                new User { Id = 2, FirstName = "Jane", LastName = "Doe", Bio = "Bio of user 2", Image = "image2.jpg", Email = "jane@example.com", CreatedOn = DateTime.Now, Active = true, IsStaff = false, Uid = "user2" },
                new User { Id = 3, FirstName = "Alex", LastName = "Smith", Bio = "Bio of user 3", Image = "image3.jpg", Email = "alex@example.com", CreatedOn = DateTime.Now, Active = true, IsStaff = false, Uid = "user3" },
                new User { Id = 4, FirstName = "Emily", LastName = "Johnson", Bio = "Bio of user 4", Image = "image4.jpg", Email = "emily@example.com", CreatedOn = DateTime.Now, Active = true, IsStaff = false, Uid = "user4" }
            });

            modelBuilder.Entity<Post>().HasData(new Post[]
            {
                new Post { Id = 1, UserId = 1, CategoryId = 1, Title = "Post 1 Title", PublicationDate = DateTime.Now, Image = "image1.jpg", Content = "Content of post 1", Approved = true },
                new Post { Id = 2, UserId = 2, CategoryId = 2, Title = "Post 2 Title", PublicationDate = DateTime.Now, Image = "image2.jpg", Content = "Content of post 2", Approved = true },
                new Post { Id = 3, UserId = 3, CategoryId = 3, Title = "Post 3 Title", PublicationDate = DateTime.Now, Image = "image3.jpg", Content = "Content of post 3", Approved = true },
                new Post { Id = 4, UserId = 4, CategoryId = 1, Title = "Post 4 Title", PublicationDate = DateTime.Now, Image = "image4.jpg", Content = "Content of post 4", Approved = false }
            });

            modelBuilder.Entity<Reaction>().HasData(new Reaction[]
            {
                new Reaction { Id = 1, Label = "Like", Image = "like.png" },
                new Reaction { Id = 2, Label = "Love", Image = "love.png" },
                new Reaction { Id = 3, Label = "Wow", Image = "wow.png" },
                new Reaction { Id = 4, Label = "Haha", Image = "haha.png" }
            });

            modelBuilder.Entity<Subscription>().HasData(new Subscription[]
            {
                new Subscription { Id = 1, FollowerId = 1, AuthorId = 2, CreatedOn = DateTime.Now, EndedOn = null },
                new Subscription { Id = 2, FollowerId = 2, AuthorId = 1, CreatedOn = DateTime.Now, EndedOn = null },
                new Subscription { Id = 3, FollowerId = 3, AuthorId = 4, CreatedOn = DateTime.Now, EndedOn = null },
                new Subscription { Id = 4, FollowerId = 4, AuthorId = 3, CreatedOn = DateTime.Now, EndedOn = null }
            });

            modelBuilder.Entity<Tag>().HasData(new Tag[]
            {
                new Tag { Id = 1, Label = "Tag 1" },
                new Tag { Id = 2, Label = "Tag 2" },
                new Tag { Id = 3, Label = "Tag 3" },
                new Tag { Id = 4, Label = "Tag 4" }
            });

            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category { Id = 1, Label = "Category 1" },
                new Category { Id = 2, Label = "Category 2" },
                new Category { Id = 3, Label = "Category 3" },
                new Category { Id = 4, Label = "Category 4" }
            });
        }

    }
}
