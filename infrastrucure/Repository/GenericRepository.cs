using Core.Entities;
using infrastrucure.Data;
using infrastrucure.Interfaces;
using infrastrucure.Spacification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _context;
        public GenericRepository(StoreContext Context)
        {
            _context = Context;
        }

        public async Task<int> CountAsync(ISpacification<T> spec)
        {
            return await ApplySpecifiction(spec).CountAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
           return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetEntityWithSpacification(ISpacification<T> spec)
        {
            return await ApplySpecifiction(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpacification<T> spec)
        {
            return await ApplySpecifiction(spec).ToListAsync();
        }

        private IQueryable<T> ApplySpecifiction(ISpacification<T> spec)
        {
            return SpacificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }
    }
}
