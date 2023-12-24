# CleanArchitecture.Shared

[![NuGet](https://img.shields.io/nuget/v/CleanArchitecture.Shared.svg)](https://www.nuget.org/packages/CleanArchitecture.Shared/)
[![NuGet](https://img.shields.io/nuget/dt/CleanArchitecture.Shared.svg)](https://www.nuget.org/packages/CleanArchitecture.Shared/)
## Overview

SharedKernel for Clean Architecture projects.

Contains abstractions:
  - AggregateRoot
  - Entity
  - Enumeration (smart enum)
  - IAuditableEntity
  - IDomainEvent (implements [MediatR.INotification]('https://www.nuget.org/packages/MediatR'))
  - IUnitOfWork
  - IEventBus
  - Result (from [FluentResult]('https://www.nuget.org/packages/FluentResult') package)

