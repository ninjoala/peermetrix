using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeerMetrix.Models
{
    public class Topic
    {
        [Key]
        public int TopicID { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string TopicBody { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        public List<Post> Posts { get; set; }
    }
}