using BugTracking.Core.Entities;
using MediatR;

namespace BugTracking.Application.Bugs.Queries;

public record GetBugQuery(int Id) : IRequest<Bug>;
