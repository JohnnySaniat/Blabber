using Microsoft.EntityFrameworkCore;
using Blabber.Models;
using Blabber.DTOs;
using Blabber;

namespace Blabber.Requests
{
    public class Users
    {
        public static void Map(WebApplication app)
        {
            // requests go inside here

            //checkUser
            app.MapPost("/checkuser/{uid}", (BlabberDbContext db, string uid) =>
            {
                var validUser = db.Users.Where(u => u.Uid == uid).ToList();
                if (validUser == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(validUser);
            });


            //viewAllUsers
            app.MapGet("/users", (BlabberDbContext db) =>
            {
                return db.Users.Include(u => u.Posts).ToList();
            });

            //viewUserDetails
            app.MapGet("/users/{uid}", (BlabberDbContext db, string uid) =>
            {
                return db.Users
                    .Include(u => u.Posts)
                    .Include(u => u.Comments)
                    .Include(u => u.Tags)
                    .Include(u => u.Subscriptions)
                    .Include(u => u.Reactions)
                    .FirstOrDefault(u => u.Uid == uid);
            });

            //createUser
            app.MapPost("/users/new", (BlabberDbContext db, CreateUserDto dto) =>
            {
                try
                {
                    User newUser = new() { FirstName = dto.FirstName, LastName = dto.LastName, Bio = dto.Bio, Image = dto.Image, Email = dto.Email, CreatedOn = DateTime.Now, Active = dto.Active, IsStaff = dto.IsStaff, Uid = dto.Uid };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    return Results.Created($"/users/new/{newUser.Id}", newUser);
                }
                catch
                {
                    return Results.BadRequest();
                }

            });

            //editUser
            app.MapPut("/users/update/{userId}", (BlabberDbContext db, int userId, CreateUserDto dto) =>
            {
                User userToUpdate = db.Users.FirstOrDefault(u => u.Id == userId);
                if (userToUpdate == null)
                {
                    return Results.NotFound();
                }
                userToUpdate.FirstName = dto.FirstName;
                userToUpdate.LastName = dto.LastName;
                userToUpdate.Bio = dto.Bio;
                userToUpdate.Image = dto.Image;
                userToUpdate.Email = dto.Email;
                userToUpdate.Active = dto.Active;
                userToUpdate.IsStaff = dto.IsStaff;
                userToUpdate.Uid = dto.Uid;

                db.SaveChanges();
                return Results.NoContent();
            });

            //deleteUser
            app.MapDelete("/users/delete/{userId}", (BlabberDbContext db, int userId) =>
            {
                User userToDelete = db.Users.FirstOrDefault(u => u.Id == userId);
                if (userToDelete == null)
                {
                    return Results.NotFound();
                }

                db.Users.Remove(userToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}