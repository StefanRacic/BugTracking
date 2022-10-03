using BugTracking.Application.Boards.Commands;
using BugTracking.Core.Entities;
using BugTracking.Dto.Board;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTracking.API.Controllers
{
    public class BoardsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Board>> Get()
        {
            return await Mediator.Send(new GetBoardsQuery());
        }

        [HttpGet("{id}")]
        public async Task<BoardDto> Get(int id)
        {
            return await Mediator.Send(new GetBoardQuery(id));
        }
    }
}
