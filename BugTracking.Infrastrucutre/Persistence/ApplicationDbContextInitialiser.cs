using BugTracking.Core.Entities;
using BugTracking.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BugTracking.Infrastrucutre.Persistence;

public class ApplicationDbContextInitialiser
{
    private readonly ILogger<ApplicationDbContextInitialiser> _logger;
    private readonly ApplicationDbContext _context;

    public ApplicationDbContextInitialiser(ILogger<ApplicationDbContextInitialiser> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task InitialAsync()
    {
        try
        {
            if (_context.Database.IsSqlServer())
                await _context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task Seed()
    {
        try
        {
            await TrySeed();
        }
        catch (Exception ex)
        {
            // Logging implementation
            throw;
        }
    }

    private async Task TrySeed()
    {
        // Default data
        // Seed if necessary
        if (!_context.Boards.Any())
        {
            _context.Boards.Add(new Board
            {
                Title = "Stefan's Board for tracking issues.",
                Description = "Default Board for keeping track of project issues.",
                Bugs =
                {
                    new Bug { Title = "Fix merge conflict #312.",
                        Description = "Check for merge issues",
                        Priority = Priority.High},
                    new Bug {Title = "Check with admins for new machine.",
                        Description = "My machine is slow and should be updated to M1 chip.",
                        Priority = Priority.Medium,
                    }
                }
            });

            await _context.SaveChangesAsync();
        }
    }
}
