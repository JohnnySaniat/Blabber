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

            app.MapDelete("/categories/{categoryId}", async (BlabberDbContext db, int categoryId) =>
            {
                try
                {
                    var category = await db.Categories.FindAsync(categoryId);

                    if (category == null)
                    {
                        return Results.NotFound();
                    }

                    db.Categories.Remove(category);
                    await db.SaveChangesAsync();

                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");

                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
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
        }
    }
}
