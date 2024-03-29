﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Blabber.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int FollowerId { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }  
        public DateTime CreatedOn { get; set; }
        public DateTime? EndedOn { get; set; }
    }
}
