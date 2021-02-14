using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PeerMetrix.Models;

namespace PeerMetrix.Dtos
{
    public class TopicReadDto
    {
        [Key]
        public int TopicID { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string TopicBody { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}