namespace CleanArchitecture.Shared.SeedWork;

public abstract record DomainEvent(Guid Id) : IDomainEvent
{
    
}