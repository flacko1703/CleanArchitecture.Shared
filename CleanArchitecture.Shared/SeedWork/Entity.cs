namespace CleanArchitecture.Shared.SeedWork;

public record Entity<T>
{
    private T Id { get; init; }
}