namespace Blabber.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Label { get; set; }

        // Navigation properties
        public ICollection<Post> Posts { get; set; }
    }
}
