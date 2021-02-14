using PeerMetrix.Models;
using Microsoft.EntityFrameworkCore;


public class PeerMetrixContext : DbContext
{
    public PeerMetrixContext(DbContextOptions<PeerMetrixContext> opt) : base (opt)
    {

    }

    // Entities        
    public DbSet<Post> Posts { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<User> Users { get; set; }


} 