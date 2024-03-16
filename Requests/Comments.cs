using Microsoft.EntityFrameworkCore;
using Blabber.Models;
using System.Data.Common;
using Blabber;

namespace E24_Amazon.Requests
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
                    id = post.Id,
                    title = post.Title,
                    image = post.Image,
                    comments = post.Comments.Select(comment => new
                    {
                        id = comment.Id,
                        authorId = comment.AuthorId,
                        postId = comment.PostId,
                        content = comment.Content,
                        createdOn = comment.CreatedOn,
                    }),
                };

                return Results.Ok(response);
            });

            // ADD A COMMENT TO A POST
            app.MapPost("/posts/{postId}/comments", (BlabberDbContext db, string comment, int postId, int authorId) =>
            {
                if (comment == null)
                {
                    return Results.NotFound("You must type something to submit");
                }

                var response = new Comment
                {
                    PostId = postId,
                    AuthorId = authorId,
                    Content = comment,
                };

                try
                {
                    db.Comments.Add(response);
                    db.SaveChanges();
                    return Results.Created($"/posts/{postId}/comments/{response.Id}", response);
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
