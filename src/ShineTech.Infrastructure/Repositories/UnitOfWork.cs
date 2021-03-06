﻿using MediatR;
using ShineTech.Domain.SeedWork;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShineTech.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RentalContext _rentalContext;
        private readonly IMediator _mediator;

        public void Dispose()
        {
            _rentalContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public UnitOfWork(RentalContext rentalContext, IMediator mediator)
        {
            _rentalContext = rentalContext;
            _mediator = mediator;
        }
        public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            int i = await _rentalContext.SaveChangesAsync(cancellationToken);
            await _mediator.DispatchDomainEventsAsync(_rentalContext);
            return i;
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
