using BugTracking.Core.Entities;
using MediatR;

namespace BugTracking.Application.Boards.Commands;

public record GetBoardQuery(int Id) : IRequest<Board>;
