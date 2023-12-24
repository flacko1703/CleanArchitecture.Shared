using MediatR;

namespace CleanArchitecture.Shared.SeedWork;

public interface IDomainEvent : INotification
{
    public Guid Id { get; }
}