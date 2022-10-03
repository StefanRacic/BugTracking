using BugTracking.Application.Boards.Commands;
using BugTracking.Dto.Board;
using MediatR;

namespace BugTracking.Application.Boards.Handlers;

public class GetBoardHandler : IRequestHandler<GetBoardQuery, BoardDto>
{
    private readonly IMediator _mediator;

    public GetBoardHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    public async Task<BoardDto> Handle(GetBoardQuery request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetBoardsQuery());
        var board = result.FirstOrDefault(b => b.Id.Equals(request.Id));
        var boardDto = new BoardDto { Id = board.Id, Title = board.Title, Description = board.Description, Bugs = board.Bugs };
        return await Task.FromResult(boardDto);
    }
}
