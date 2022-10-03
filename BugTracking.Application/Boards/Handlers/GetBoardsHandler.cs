using BugTracking.Application.Boards.Commands;
using BugTracking.Application.Common.Interfaces;
using BugTracking.Core.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BugTracking.Application.Boards.Handlers;

public class GetBoardsHandler : IRequestHandler<GetBoardsQuery, List<Board>>
{
    private readonly IApplicationDbContext _context;

    public GetBoardsHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Board>> Handle(GetBoardsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Boards.ToListAsync(cancellationToken);
    }
}
