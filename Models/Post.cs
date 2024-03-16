using System.Collections.Generic;

namespace Blabber.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public bool Approved { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Reaction> Reactions { get; set; }

    }
}
