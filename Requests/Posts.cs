using Blabber.DTOs;
using Blabber.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Blabber.Requests
{
    public class Posts
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/posts", async (BlabberDbContext db) =>
            {
                try
                {
                    var posts = await db.Posts
                        .Include(p => p.User)
                        .Include(p => p.Comments)
                        .Include(p => p.Tags)
                        .Include(p => p.Reactions)
                        .ToListAsync();

                    return Results.Ok(posts);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.Ok(new List<Post>());
                }
            });

            app.MapGet("/posts/{postId}", (BlabberDbContext db, int postId) =>
            {
                try
                {
                    var post = db.Posts
                        .Include(p => p.User)
                        .Include(p => p.Comments)
                        .Include(p => p.Tags)
                        .Include(p => p.Reactions)
                        .FirstOrDefault(p => p.Id == postId);

                    if (post == null)
                    {
                        return Results.NotFound();
                    }

                    return Results.Ok(post);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.NotFound();
                }
            });

            app.MapGet("/posts/user/{uid}", (BlabberDbContext db, string uid) =>
            {
                try
                {
                    var post = db.Posts
                        .Include(p => p.User)
                        .Include(p => p.Comments)
                        .Include(p => p.Tags)
                        .Include(p => p.Reactions)
                        .FirstOrDefault(p => p.Uid == uid);

                    if (post == null)
                    {
                        return Results.NotFound();
                    }

                    return Results.Ok(post);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return Results.NotFound();
                }
            });

            app.MapDelete("/posts/{postId}", async (BlabberDbContext db, int postId) =>
            {
                try
                {
                    var post = await db.Posts.FindAsync(postId);

                    if (post == null)
                    {
                        return Results.NotFound();
                    }

                    db.Posts.Remove(post);
                    await db.SaveChangesAsync();

                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });
            app.MapPost("/posts", async (BlabberDbContext db, PostDto postDto) =>
            {
                try
                {
                    if (postDto == null)
                    {
                        return Results.BadRequest("Invalid post data.");
                    }

                    var user = await db.Users.FindAsync(postDto.UserId);
                    if (user == null)
                    {
                        return Results.BadRequest("Invalid user ID.");
                    }

                    var category = await db.Categories.FindAsync(postDto.CategoryId);
                    if (category == null)
                    {
                        return Results.BadRequest("Invalid category ID.");
                    }

                    if (string.IsNullOrEmpty(postDto.Uid))
                    {
                        var post = new Post
                        {
                            UserId = postDto.UserId,
                            CategoryId = postDto.CategoryId,
                            Title = postDto.Title,
                            PublicationDate = DateTime.Now,
                            Image = postDto.Image,
                            Content = postDto.Content,
                            Approved = false
                        };

                        db.Posts.Add(post);
                        await db.SaveChangesAsync();

                        return Results.Created($"/posts/{post.Id}", post);
                    }
                    else
                    {
                        var existingPost = await db.Posts.FirstOrDefaultAsync(p => p.Uid == postDto.Uid);
                        if (existingPost == null)
                        {
                            return Results.NotFound();
                        }

                        existingPost.UserId = postDto.UserId;
                        existingPost.CategoryId = postDto.CategoryId;
                        existingPost.Title = postDto.Title;
                        existingPost.Image = postDto.Image;
                        existingPost.Content = postDto.Content;

                        await db.SaveChangesAsync();

                        return Results.Ok(existingPost);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapPut("/posts/{postId}", async (BlabberDbContext db, int postId, PostDto postDto) =>
            {
                try
                {
                    var post = await db.Posts.FindAsync(postId);

                    if (post == null)
                    {
                        return Results.NotFound();
                    }

                    // Update post fields
                    post.UserId = postDto.UserId;
                    post.CategoryId = postDto.CategoryId;
                    post.Title = postDto.Title;
                    post.PublicationDate = postDto.PublicationDate;
                    post.Image = postDto.Image;
                    post.Content = postDto.Content;
                    post.Approved = postDto.Approved;

                    await db.SaveChangesAsync();

                    return Results.Ok(post);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapPatch("/posts/{postId}", async (BlabberDbContext db, int postId, PostDto postDto) =>
            {
                try
                {
                    var post = await db.Posts.FindAsync(postId);

                    if (post == null)
                    {
                        return Results.NotFound();
                    }

                    // Update post fields
                    post.CategoryId = postDto.CategoryId;
                    post.Title = postDto.Title;
                    post.Image = postDto.Image;
                    post.Content = postDto.Content;

                    await db.SaveChangesAsync();

                    return Results.Ok(post);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapDelete("/posts/{postId}/categories/{categoryId}", async (BlabberDbContext db, int postId, int categoryId) =>
            {
                try
                {
                    var post = await db.Posts.FindAsync(postId);

                    if (post == null)
                    {
                        return Results.NotFound();
                    }

                    var category = await db.Categories.FindAsync(categoryId);

                    if (category == null)
                    {
                        return Results.NotFound();
                    }

                    post.CategoryId = null; 

                    await db.SaveChangesAsync();

                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapPut("/posts/{postId}/categories/{categoryId}", async (BlabberDbContext db, int postId, int categoryId) =>
            {
                try
                {
                    var post = await db.Posts.FindAsync(postId);

                    if (post == null)
                    {
                        return Results.NotFound();
                    }

                    var category = await db.Categories.FindAsync(categoryId);

                    if (category == null)
                    {
                        return Results.NotFound();
                    }

                    post.CategoryId = categoryId;

                    await db.SaveChangesAsync();

                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

        }
    }
}