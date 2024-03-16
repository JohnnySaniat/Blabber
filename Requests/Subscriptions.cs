using Microsoft.EntityFrameworkCore;
using Blabber.Models;
using Blabber.DTOs;
using Blabber;

namespace Blabber.Requests
{
    public class Subscriptions
    {
        public static void Map(WebApplication app)
        {
            // requests go inside here

            //createSubscription
            app.MapPost("/subscription/new", (BlabberDbContext db, SubscriptionDto dto) =>
            {
                try
                {
                    Subscription newSubscription = new() { FollowerId = dto.FollowerId, AuthorId = dto.AuthorId, CreatedOn = dto.CreatedOn, EndedOn = dto.EndedOn };
                    db.Subscriptions.Add(newSubscription);
                    db.SaveChanges();
                    return Results.Created($"/subscription/new/{newSubscription.Id}", newSubscription);
                }
                catch
                {
                    return Results.BadRequest();
                }

            });

            //viewSubscriptionsByUser
            app.MapGet("/subscriptions/{userId}", (BlabberDbContext db, int userId) =>
            {
                return db.Subscriptions.Where(s => s.FollowerId == userId).ToList();
            });

            //removeSubscriptionsFromUser
            app.MapDelete("/subscriptions/{userId}/remove/{authorId}", (BlabberDbContext db, int userId, int authorId) =>
            {
                Subscription removeSubscription = db.Subscriptions.FirstOrDefault(s => s.FollowerId == userId && s.AuthorId == authorId);
                if (removeSubscription == null)
                {
                    return Results.NotFound();
                }
                db.Subscriptions.Remove(removeSubscription);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
