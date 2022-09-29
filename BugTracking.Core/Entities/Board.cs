namespace BugTracking.Core.Entities;

public class Board : BaseAuditableEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public IList<Bug> Bugs { get; set; }
}
