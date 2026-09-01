namespace CodeSync.Domain.Entities;

public class DocumentVersion
{
     public Guid Id { get; set; }
      public Guid DocumentId    { get; set; }

    public string Content   { get; set; } = string.Empty;

    public long VersionNumber { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public string Message   { get; set; } = string.Empty;
}



// Id              → Guid
// VersionNumber   → long
// DocumentId      → Guid
// Content         → string
// CreatedByUserId → Guid
// CreatedAt       → DateTime
// Message         → string?