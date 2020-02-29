using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShineTech.Domain.Models.Users;
using ShineTech.Domain.SeedWork;

namespace ShineTech.Infrastructure.Repositories.Customers
{
    public class UserRepository : IUserRepository
    {
        private readonly RentalContext _context;
        public UserRepository(RentalContext context)
        {
            _context = context ?? throw CustomException.NullArgument(nameof(context));
        }
        public void Add(User entity)
        {
            _context.Users.Add(entity);
        }

        public async Task<IEnumerable<User>> FindAllAsync(ISpecification<User> specification)
        {
            var query = specification.Includes
                .Aggregate(_context.Set<User>().AsQueryable(), (current, include) => current.Include(include));
            return await query.Where(specification.Expression).AsNoTracking().ToListAsync();
        }

        public async Task<User> FindOneAsync(ISpecification<User> specification)
        {
            var query = specification.Includes
                .Aggregate(_context.Set<User>().AsQueryable(), (current, include) => current.Include(include));
            return await query.FirstOrDefaultAsync(specification.Expression);
        }

        public void Remove(User entity)
        {
            _context.Users.Remove(entity);
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
        }
    }
}
