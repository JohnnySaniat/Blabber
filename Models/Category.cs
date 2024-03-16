namespace Blabber.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Label { get; set; }

        // Navigation properties
        public ICollection<Post> Posts { get; set; }
    }
}
