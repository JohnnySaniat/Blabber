namespace Blabber.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }
        public bool IsStaff { get; set; }
        public string Uid { get; set; }

        // Navigation properties
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
