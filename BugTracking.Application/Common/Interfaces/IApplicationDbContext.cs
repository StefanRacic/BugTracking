using BugTracking.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugTracking.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Bug> Bugs { get; }
    DbSet<Board> Boards { get; }
}
