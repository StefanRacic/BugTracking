using BugTracking.Application.Bugs.Queries;
using BugTracking.Core.Entities;
using MediatR;

namespace BugTracking.Application.Bugs.Handlers;

public class GetBugQueryHandler : IRequestHandler<GetBugQuery, Bug>
{
    private readonly IMediator _mediator;

    public GetBugQueryHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    public async Task<Bug> Handle(GetBugQuery request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetBugsQuery());
        return await Task.FromResult(result.FirstOrDefault(b => b.Id.Equals(request.Id)));
    }
}
