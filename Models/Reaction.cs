namespace Blabber.Models
{
    public class Reaction
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Image { get; set; }

        // Navigation properties
        public ICollection<Post> Posts { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
