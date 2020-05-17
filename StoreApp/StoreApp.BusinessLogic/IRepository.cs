using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;

namespace StoreApp.BusinessLogic
{
    public interface IRepository<TEntity> where TEntity : class
        //public interface IRepository
    {
        // filter out admins
        //Task<List<User>> GetCustomersAsync(string firstName, string lastName);
        //Task<Order> GetOrderAsync(int orderID);
        //Task<List<Order>> GetOrdersByLocAsync(int locationID);
        //Task<List<Order>> GetOrdersByCustAsync(int customerID);
        //Task AddCustomer(User customer);
        //Task<IEnumerable<Product>> GetProductsAsync();
        //Task<Product> GetProductAsync(int? productID);

        Task AddAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        //Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
    }
}