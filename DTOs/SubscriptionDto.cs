using System;
namespace Blabber.DTOs
{
    public class SubscriptionDto
    {
        public int FollowerId { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? EndedOn { get; set; }
    }
}
