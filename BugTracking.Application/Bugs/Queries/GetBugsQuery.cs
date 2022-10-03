using BugTracking.Core.Entities;
using MediatR;

namespace BugTracking.Application.Bugs.Queries;

public record GetBugsQuery : IRequest<List<Bug>>;