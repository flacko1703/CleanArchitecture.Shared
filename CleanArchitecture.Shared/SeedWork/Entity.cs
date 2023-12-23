namespace CleanArchitecture.Shared.SeedWork;

public abstract class Entity<T>
{
    protected T Id { get; init; }
}