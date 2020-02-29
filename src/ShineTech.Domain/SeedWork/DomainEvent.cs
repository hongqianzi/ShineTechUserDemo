using System;

namespace ShineTech.Domain.SeedWork
{
    public class DomainEvent : IDomainEvent
    {
        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
