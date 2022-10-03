namespace BugTracking.Core.Exceptions.Bug;
public class BugNotFoundException : Exception
{
    public BugNotFoundException(int bugId)
        : base($"The Bug with the identifier {bugId} was not found.")
    {
    }
}
