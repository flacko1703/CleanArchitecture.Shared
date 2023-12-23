namespace CleanArchitecture.Shared.SeedWork;

public record AuditableEntity<T> : Entity<T>
{
    DateTime CreatedAtUtc { get; init; }
    DateTime? UpdatedAtUtc { get; init; }
    
    uint Version { get; init; }
}