namespace CodeSync.Domain.Entities;

using CodeSync.Domain.Enums;

public class WorkspaceMember
{
    public Guid UserId { get; set; }

    public Guid WorkspaceId { get; set; }

    public WorkspaceRole Role { get; set; }

    public DateTime JoinedAt { get; set; }
}