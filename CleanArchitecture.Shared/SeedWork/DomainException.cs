namespace CleanArchitecture.Shared.SeedWork;

public abstract class DomainException : Exception
{
    protected DomainException(string? message) 
        : base(message)
    {
        
    }
}