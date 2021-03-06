﻿using System;
using System.Collections.Generic;

namespace ShineTech.Domain.SeedWork
{
    public abstract class Entity
    {
        public virtual Guid Id { get; private set; }

        private List<IDomainEvent> _domainEvents;
        public List<IDomainEvent> DomainEvents => _domainEvents;

        public void AddDomainEvent(IDomainEvent eventItem)
        {
            _domainEvents = _domainEvents ?? new List<IDomainEvent>();
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(IDomainEvent eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }
    }


}
