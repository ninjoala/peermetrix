using System.ComponentModel.DataAnnotations;

namespace PeerMetrix.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}