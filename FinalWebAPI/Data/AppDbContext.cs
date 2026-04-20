using Microsoft.EntityFrameworkCore;
using FinalWebAPI.Models;

namespace FinalWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
