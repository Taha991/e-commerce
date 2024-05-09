using Core.Entities;
using infrastrucure.Spacification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync (int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetEntityWithSpacification(ISpacification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpacification<T> spec);
        Task<int> CountAsync(ISpacification<T> spec);

    }
}
