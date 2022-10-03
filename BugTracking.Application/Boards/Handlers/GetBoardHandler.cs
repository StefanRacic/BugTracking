using BugTracking.Application.Boards.Commands;
using BugTracking.Core.Entities;
using MediatR;

namespace BugTracking.Application.Boards.Handlers;

public class GetBoardHandler : IRequestHandler<GetBoardQuery, Board>
{
    private readonly IMediator _mediator;

    public GetBoardHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    public async Task<Board> Handle(GetBoardQuery request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetBoardsQuery());
        return await Task.FromResult(result.FirstOrDefault(b => b.Id.Equals(request.Id)));
    }
}
