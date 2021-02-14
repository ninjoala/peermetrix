using System.ComponentModel.DataAnnotations;

namespace PeerMetrix.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string PostBody { get; set; }
        public bool IsFlagged { get; set; }

        [Required]
        public int UserId { get; set; }
        
        public User User { get; set; }
        
    }
}