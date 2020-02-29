using MediatR;
using System;

namespace ShineTech.Domain.SeedWork
{
    public interface IDomainEvent : INotification
    {
        DateTime CreatedAt { get; }
    }
}
