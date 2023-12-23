namespace CleanArchitecture.Shared.SeedWork;

public abstract class AuditableEntity<T> : Entity<T>
{
    DateTime CreatedAtUtc { get; init; }
    DateTime? UpdatedAtUtc { get; init; }
    
    uint Version { get; init; }
}