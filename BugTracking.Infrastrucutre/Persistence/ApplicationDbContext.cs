using BugTracking.Application.Common.Interfaces;
using BugTracking.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugTracking.Infrastrucutre.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Board> Boards { get; set; }
    }
}
