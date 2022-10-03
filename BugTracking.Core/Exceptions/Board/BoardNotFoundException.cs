namespace BugTracking.Core.Exceptions.Board;
public class BoardNotFoundException : Exception
{
    public BoardNotFoundException(int boardId)
        : base($"The board with the identifier {boardId} was not found.")
    {
    }
}
