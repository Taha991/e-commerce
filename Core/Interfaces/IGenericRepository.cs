using Core.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetEntityWithSpecification(Specification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(Specification<T> spec);
        Task<int> CountAsync(Specification<T> spec);
    }
}
