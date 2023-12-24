namespace CleanArchitecture.Shared.SeedWork;

public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
{
    public DateTime CreatedAtUtc { get; init; }
    public DateTime? UpdatedAtUtc { get; init; }

    public uint Version { get; init; }
}