namespace CodeSync.Domain.Entities;

public class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string DisplayName { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string? GitHubUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsActive { get; set; } = true;
}