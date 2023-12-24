namespace CleanArchitecture.Shared.SeedWork;

public abstract class Entity<T>
{
    public T Id { get; init; }
}