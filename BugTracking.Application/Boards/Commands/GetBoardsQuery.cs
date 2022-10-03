using BugTracking.Core.Entities;
using MediatR;

namespace BugTracking.Application.Boards.Commands;

public record GetBoardsQuery : IRequest<List<Board>>;
