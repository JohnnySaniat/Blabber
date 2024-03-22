using System;
namespace Blabber.DTOs
{
    public class CreateUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public bool IsStaff { get; set; }
        public string Uid { get; set; }
    }
}