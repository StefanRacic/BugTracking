using BugTracking.Core.Entities;

namespace BugTracking.Dto.Board
{
    public class BoardDto
    {
        public BoardDto()
        {
            Bugs = new List<Bug>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public IList<Bug> Bugs { get; set; }
    }
}
