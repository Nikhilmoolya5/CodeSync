namespace CodeSync.Domain.Entities;

public class Folder
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public Guid WorkspaceId { get; set; }

    public Guid? ParentFolderId { get; set; }

    public DateTime CreatedAt { get; set; }
}