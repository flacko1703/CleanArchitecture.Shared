# CleanArchitecture.Shared

[![NuGet](https://img.shields.io/nuget/v/CleanArchitecture.Shared.svg)](https://www.nuget.org/packages/CleanArchitecture.Shared/)
[![NuGet](https://img.shields.io/nuget/dt/CleanArchitecture.Shared.svg)](https://www.nuget.org/packages/CleanArchitecture.Shared/)
## Overview

SharedKernel for Clean Architecture projects.

Contains abstractions:
- AggregateRoot
- Entity
- ValueObject
- Enumeration (smart enum)
- IAuditableEntity as Interface
- AuditableEntity as abstract class
- IDomainEvent (implements [MediatR.INotification]('https://www.nuget.org/packages/MediatR'))
- DomainException
- IUnitOfWork
- IEventBus
- Result (from [FluentResult]('https://www.nuget.org/packages/FluentResult') package)
- Options extensions (from [Microsoft.Extensions.Options]('https://www.nuget.org/packages/Microsoft.Extensions.Options') package)
- ICommand, ICommandHandler, ICommandDispatcher, InMemoryCommandDispatcher
- IQuery, IQueryHandler, IQueryDispatcher, InMemoryQueryDispatcher
## Installation

Using .NET CLI:

```bash
dotnet add package CleanArchitecture.Shared
```

Using Package Manager:

```bash
Install-Package CleanArchitecture.Shared
```