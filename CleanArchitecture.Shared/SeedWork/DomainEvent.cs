namespace CleanArchitecture.Shared.SeedWork;

public record DomainEvent<T>(T Id) : IDomainEvent 
{
    
}