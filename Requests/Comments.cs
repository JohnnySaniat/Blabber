﻿using Microsoft.EntityFrameworkCore;
using Blabber.Models;
using System.Data.Common;
using Blabber;

namespace Blabber.Requests
{
    public class Comments
    {
        public static void Map(WebApplication app)
        {
            // VIEW POST COMMENTS
            app.MapGet("/posts/{postId}/comments", (BlabberDbContext db, int postId) =>
            {
                var post = db.Posts.Include(p => p.Comments).Include(p => p.User).SingleOrDefault(p => p.Id == postId);

                if (post == null)
                {
                    return Results.NotFound("Unable to find requested data");
                }

                var response = new
                {
                    comments = post.Comments.Select(comment => new
                    {
                        id = comment.Id,
                        authorId = comment.AuthorId,
                        postId = comment.PostId,
                        Author = db.Users.Where(u => u.Id == comment.AuthorId)
                            .Select(u => u.FirstName + " " +  u.LastName).FirstOrDefault(),
                        content = comment.Content,
                        createdOn = comment.CreatedOn.ToString("MM/dd/yy"),
                    }),
                };

                return Results.Ok(response);
            });

            // ADD A COMMENT TO A POST
            app.MapPost("/posts/{postId}/comments", (BlabberDbContext db, Comment newComment, int postId) =>
            {
                var post = db.Posts.FirstOrDefault(p => p.Id == postId);
                if (post == null)
                {
                    return Results.NotFound("Unable to find post");
                }

                if (string.IsNullOrEmpty(newComment.Content))
                {
                    return Results.BadRequest("Comments cannot be empty");
                }

                var authorId = newComment.AuthorId;
                var comment = new Comment
                {
                    PostId = postId,
                    AuthorId = authorId,
                    Content = newComment.Content,
                    CreatedOn = DateTime.Now,
                };

                try
                {
                    db.Comments.Add(comment);
                    db.SaveChanges();
                    return Results.Created($"/posts/{postId}/comments/{comment.Id}", comment);
                }
                catch (DbException ex)
                {
                    return Results.BadRequest($"There was an error: {ex.Message}");
                }
            });

            // UPDATE EXISTING COMMENT
            app.MapPut("/posts/{postId}/comments/{commentId}", (BlabberDbContext db, int postId, int commentId, string updatedComment) =>
            {
                var post = db.Posts.Include(p => p.Comments).SingleOrDefault(p => p.Id == postId);
                Comment commentToUpdate = db.Comments.SingleOrDefault(c => c.Id == commentId);

                if (commentToUpdate == null)
                {
                    return Results.NotFound("There was an error, the comment you requested was not found");
                }

                commentToUpdate.Content = updatedComment;

                db.SaveChanges();
                return Results.NoContent();
            });

            // DELETE SPECIFIC COMMENT FROM A SPECIFIC POST
            app.MapDelete("/posts/{postId}/comments/{commentId}", (BlabberDbContext db, int postId, int commentId) =>
            {
                var post = db.Posts.Include(p => p.Comments).FirstOrDefault(p => p.Id == postId);
                var comment = db.Comments.Find(commentId);

                if (post == null || comment == null)
                {
                    return Results.NotFound("Unable to find the requested data");
                }

                post.Comments.Remove(comment);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
