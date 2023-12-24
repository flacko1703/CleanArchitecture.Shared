﻿namespace CleanArchitecture.Shared.SeedWork;

public abstract class AggregateRoot<T> : AuditableEntity<T>, IDomainEvent
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public Guid Id { get; }
}