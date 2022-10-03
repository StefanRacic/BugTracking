using BugTracking.Dto.Board;
using MediatR;

namespace BugTracking.Application.Boards.Commands;

public record GetBoardQuery(int Id) : IRequest<BoardDto>;
