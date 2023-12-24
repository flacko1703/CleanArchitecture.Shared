namespace CleanArchitecture.Shared.SeedWork;

public interface IAuditableEntity
{
    DateTime CreatedAtUtc { get; init; }
    DateTime? UpdatedAtUtc { get; init; }
    
    uint Version { get; init; }
    
}