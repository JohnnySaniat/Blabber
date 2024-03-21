using Blabber.Models;
using Microsoft.EntityFrameworkCore;

namespace Blabber.Requests
{
    public class Categories
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/categories", async (BlabberDbContext db) =>
            {
                try
                {
                    var categories = await db.Categories
                        .Include(c => c.Posts)
                        .ToListAsync();

                    return Results.Ok(categories);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapPost("/categories", async (BlabberDbContext db, Category category) =>
            {
                try
                {
                    if (category == null)
                    {
                        return Results.BadRequest("Invalid category data.");
                    }

                    db.Categories.Add(category);
                    await db.SaveChangesAsync();

                    return Results.Created($"/categories/{category.Id}", category);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapDelete("/categories/{id}", (BlabberDbContext db, int id) =>
            {
                var category = db.Categories.FirstOrDefault(c => c.Id == id);
                if (category == null)
                {
                    return Results.NotFound();
                }

                var posts = db.Posts.Where(p => p.CategoryId == id).ToList();
                if (posts.Any())
                {
                    foreach (var post in posts)
                    {
                        post.CategoryId = null;
                    }
                }

                db.Categories.Remove(category);
                db.SaveChanges();

                return Results.Ok();
            });

            app.MapPut("/categories/{categoryId}", async (BlabberDbContext db, int categoryId, Category updatedCategory) =>
            {
                try
                {
                    var category = await db.Categories.FindAsync(categoryId);

                    if (category == null)
                    {
                        return Results.NotFound();
                    }

                    category.Label = updatedCategory.Label;

                    await db.SaveChangesAsync();

                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapGet("/categories/{categoryId}/posts", async (BlabberDbContext db, int categoryId) =>
            {
                try
                {
                    var category = await db.Categories.Include(c => c.Posts).FirstOrDefaultAsync(c => c.Id == categoryId);

                    if (category == null)
                    {
                        return Results.NotFound();
                    }

                    return Results.Ok(category.Posts);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            app.MapGet("/categories/{categoryId}", async (BlabberDbContext db, int categoryId) =>
            {
                try
                {
                    var category = await db.Categories
                        .Include(c => c.Posts)
                        .FirstOrDefaultAsync(c => c.Id == categoryId);

                    if (category == null)
                    {
                        return Results.NotFound();
                    }

                    return Results.Ok(category);
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
