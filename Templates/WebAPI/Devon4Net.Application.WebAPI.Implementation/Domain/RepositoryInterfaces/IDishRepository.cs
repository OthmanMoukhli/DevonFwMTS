using System.Linq.Expressions;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.Application.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    public interface IDishRepository : IRepository<Dish> {
        Task<IList<Dish>> GetAll(Expression<Func<Dish, bool>> predicate = null);

        Task<IList<Dish>> GetAllNested(IList<string> nestedProperties, Expression<Func<Dish, bool>> predicate = null);

        Task<Dish> GetDishById(long id);
    }

}