using Microsoft.EntityFrameworkCore;
using Blabber.Models;
using Blabber.DTOs;
using Blabber;
using Blabber.DTOs;

namespace Blabber.Requests
{
    public class Tags
    {
        public static void Map(WebApplication app)
        {
            // requests go inside here

            //viewAllTags
            app.MapGet("/tags", (BlabberDbContext db) =>
            {
                return db.Tags.ToList();
            });

            //viewTagDetails
            app.MapGet("/tags/{tagId}", (BlabberDbContext db, int tagId) =>
            {
                return db.Tags.FirstOrDefault(t => t.Id == tagId);
            });

            //viewPostsByTag
            app.MapGet("/tags/posts/{tagId}", (BlabberDbContext db, int tagId) =>
            {
                return db.Posts
                    .Include(p => p.Tags)
                    .Where(p => p.Tags.Any(t => t.Id == tagId))
                    .ToList();
            });

            //createTag
            app.MapPost("/tags/new", (BlabberDbContext db, CreateTagDto dto) =>
            {
                try
                {
                    Tag newTag = new() { Label = dto.Label };
                    db.Tags.Add(newTag);
                    db.SaveChanges();
                    return Results.Created($"/tags/new/{newTag.Id}", newTag);
                }
                catch
                {
                    return Results.BadRequest();
                }
            });

            //editTag
            app.MapPut("/tags/update/{tagId}", (BlabberDbContext db, int tagId, CreateTagDto dto) =>
            {
                Tag tagToUpdate = db.Tags.FirstOrDefault(t => t.Id == tagId);
                if (tagToUpdate == null)
                {
                    return Results.NotFound();
                }

                tagToUpdate.Label = dto.Label;
                db.SaveChanges();
                return Results.NoContent();

            });

            //deleteTag
            app.MapDelete("/tags/delete/{tagId}", (BlabberDbContext db, int tagId) =>
            {
                Tag tagToDelete = db.Tags.FirstOrDefault(t => t.Id == tagId);
                if (tagToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Tags.Remove(tagToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });

            //removeTagFromPost
            app.MapDelete("/posts/tags/remove/{postId}/{tagId}", (BlabberDbContext db, int postId, int tagId) =>
            {
                Post thisPost = db.Posts.Include(p => p.Tags).FirstOrDefault(p => p.Id == postId);
                Tag tagToRemove = db.Tags.FirstOrDefault(t => t.Id == tagId);

                thisPost.Tags.Remove(tagToRemove);
                db.SaveChanges();
                return Results.NoContent();
            });

            //addTagToPost
            app.MapPost("/posts/tags/add", (BlabberDbContext db, PostTagsDTO dto) =>
            {
                Post thisPost = db.Posts.FirstOrDefault(p => p.Id == dto.PostId);
                Tag tagToAdd = db.Tags.FirstOrDefault(t => t.Id == dto.TagId);

                thisPost.Tags.Add(tagToAdd);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}