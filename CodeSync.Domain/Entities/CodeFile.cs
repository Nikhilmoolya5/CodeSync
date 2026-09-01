namespace CodeSync.Domain.Entities;

public class CodeFile
{
    public Guid Id { get; set; }

    public string FileName { get; set; } = string.Empty;

    public Guid WorkspaceId { get; set; }

    public Guid? FolderId { get; set; }

    public string Language { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public DateTime LastModifiedAt { get; set; }
}