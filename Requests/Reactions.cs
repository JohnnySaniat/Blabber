using Blabber;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Blabber.DTOs;
using Blabber.Models;

namespace E24_Amazon.Requests
{
    public class Reactions
    {
        public static void Map(WebApplication app)
        {
            // VIEW ALL REACTIONS
            app.MapGet("/reactions", (BlabberDbContext db) =>
            {
                return db.Reactions.ToList();
            });

            // VIEW REACTION DETAILS 
            app.MapGet("/reactions/{id}", (BlabberDbContext db, int id) =>
            {
                var reaction = db.Reactions.Include(r => r.Posts).SingleOrDefault(r => r.Id == id);

                if (reaction == null)
                {
                    return Results.NotFound("Unable to find requested data");
                }

                var response = new
                {
                    id = reaction.Id,
                    label = reaction.Label,
                    image = reaction.Image,
                    posts = reaction.Posts.Select(post => new
                    {
                        id = post.Id,
                        title = post.Title,
                        image = post.Image,
                        content = post.Content
                    }),
                };

                return Results.Ok(response);
            });

            // VIEW POST REACTIONS
            app.MapGet("/posts/{postId}/reactions", (BlabberDbContext db, int postId) =>
            {
                var post = db.Posts.Include(p => p.Reactions).SingleOrDefault(p => p.Id == postId);

                if (post == null)
                {
                    return Results.NotFound("Unable to find post");
                }

                var response = new
                {
                    id = post.Id,
                    title = post.Title,
                    image = post.Image,
                    reactions = post.Reactions.Select(reaction => new
                    {
                        id = reaction.Id,
                        label = reaction.Label,
                        image = reaction.Image
                    })
                };

                return Results.Ok(response);
            });

            // CREATE A REACTION
            app.MapPost("/reactions", (BlabberDbContext db, Reaction newReaction) =>
            {
                try
                {
                    db.Reactions.Add(newReaction);
                    db.SaveChanges();
                    return Results.Created($"/reactions/{newReaction.Id}", newReaction);
                }
                catch (DbException)
                {
                    return Results.NotFound("Invalid data submitted.");
                }
            });

            // DELETE A REACTION
            app.MapDelete("/reactions/{id}", (BlabberDbContext db, int id) =>
            {
                var reaction = db.Reactions.SingleOrDefault(r => r.Id == id);

                if (reaction == null)
                {
                    return Results.NotFound();
                }

                db.Reactions.Remove(reaction);
                db.SaveChanges();
                return Results.NoContent();
            });

            // ADD A REACTION TO POST
            app.MapPost("/posts/{postId}/reactions", (BlabberDbContext db, PostReactionsDTO newReaction) =>
            {
                var post = db.Posts.Include(p => p.Reactions).FirstOrDefault(p => p.Id == newReaction.PostId);
                var reactionToAdd = db.Reactions.Find(newReaction.ReactionId);

                if (post == null || reactionToAdd == null)
                {
                    return Results.NotFound();
                }

                try
                {
                    post.Reactions.Add(reactionToAdd);
                    db.SaveChanges();
                    return Results.Created($"/posts/{newReaction.PostId}/reactions/{newReaction.ReactionId}", reactionToAdd);
                }
                catch
                {
                    return Results.BadRequest("There was an error with the data submitted");
                }
            });

            // REMOVE A REACTION FROM A POST
            app.MapDelete("/posts/{postId}/reactions/{reactionId}", (BlabberDbContext db, int postId, int reactionId) =>
            {
                var post = db.Posts.Include(p => p.Reactions).FirstOrDefault(p => p.Id == postId);
                var reaction = db.Reactions.Find(reactionId);

                if (post == null || reaction == null)
                {
                    return Results.NotFound("Unable to find the requested data");
                }

                post.Reactions.Remove(reaction);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
