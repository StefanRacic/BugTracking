using BugTracking.Application.Bugs.Queries;
using BugTracking.Application.Common.Interfaces;
using BugTracking.Core.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BugTracking.Application.Bugs.Handlers;
public class GetBugsQueryHandler : IRequestHandler<GetBugsQuery, List<Bug>>
{
    private readonly IApplicationDbContext _context;

    public GetBugsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Bug>> Handle(GetBugsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Bugs.ToListAsync(cancellationToken);
    }
}
