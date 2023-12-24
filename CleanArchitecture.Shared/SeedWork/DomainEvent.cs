namespace CleanArchitecture.Shared.SeedWork;

public record DomainEvent<T>(Guid Id) : IDomainEvent
{
    
}