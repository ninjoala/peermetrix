using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PeerMetrix.Models;

namespace PeerMetrix.Dtos
{
    public class TopicUpdateDto
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