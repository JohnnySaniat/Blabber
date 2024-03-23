using Blabber.DTOs;
using Blabber.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Blabber;

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

            app.MapGet("/posts/{id}", (BlabberDbContext db, int id) =>
            {
                var post = db.Posts
                    .Include(p => p.User)
                    .Include(p => p.Comments)
                    .Include(p => p.Tags)
                    .Include(p => p.Reactions)
                    .FirstOrDefault(p => p.Id == id);

                if (post != null)
                {
                    return Results.Ok(post);
                }
                else
                {
                    return Results.NotFound();
                }
            });

            app.MapGet("/posts/users/{uid}", (BlabberDbContext db, string uid) =>
            {
                try
                {
                    var posts = db.Posts
                        .Include(p => p.User)
                        .Include(p => p.Comments)
                        .Include(p => p.Tags)
                        .Include(p => p.Reactions)
                        .Where(p => p.Uid == uid)
                        .ToList();

                    if (posts == null || posts.Count == 0)
                    {
                        return Results.NotFound();
                    }

                    return Results.Ok(posts);
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

            app.MapPost("/posts", (BlabberDbContext db, Post newPost) =>
            {
                db.Posts.Add(newPost);
                db.SaveChanges();
                return Results.Created($"/api/posts/{newPost.Id}", newPost);
            });

            app.MapPut("/posts/{id}", (BlabberDbContext db, int id, Post updatedPost) =>
            {
                var postToUpdate = db.Posts.SingleOrDefault(p => p.Id == id);
                if (postToUpdate == null)
                {
                    return Results.NotFound();
                }

                postToUpdate.Title = updatedPost.Title;
                postToUpdate.Image = updatedPost.Image;
                postToUpdate.CategoryId = updatedPost.CategoryId;
                postToUpdate.Content = updatedPost.Content;

                db.SaveChanges();

                return Results.Ok(postToUpdate);
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

            app.MapGet("/posts/search", (BlabberDbContext db, string searchValue) =>
            {
                var searchResults = db.Posts
                    .Include(p => p.User)
                    .Include(p => p.Category)
                    .Where(p =>
                        p.Title.ToLower().Contains(searchValue.ToLower()) ||
                        p.Content.ToLower().Contains(searchValue.ToLower()) ||
                        p.Image.ToLower().Contains(searchValue.ToLower()) ||
                        p.Uid.ToLower().Contains(searchValue.ToLower()) ||
                        p.PublicationDate.ToString().Contains(searchValue) ||
                        p.UserId.ToString().Contains(searchValue) ||
                        (p.Category != null && p.Category.Label.ToLower().Contains(searchValue.ToLower()))
                    )
                    .ToList();

                return searchResults.Any() ? Results.Ok(searchResults) : Results.StatusCode(204);
            });

        }
    }
}