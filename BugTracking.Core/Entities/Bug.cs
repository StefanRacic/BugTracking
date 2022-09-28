
namespace BugTracking.Core.Entities;

public class Bug : BaseAuditableEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsArchived { get; set; }
}
