using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace StoreApp.BusinessLogic
{
    public interface IRepository
    {
        // filter out admins
        Task<List<User>> GetCustomersAsync( string firstName, string lastName );
        Task<Order> GetOrderAsync( int orderID );
        Task<List<Order>> GetOrdersByLocAsync( int locationID );
        Task<List<Order>> GetOrdersByCustAsync( int customerID );
        Task AddCustomer(User customer);

        //Task<List<Product>> GetProductsAsync();
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductAsync( int? productID );
    }
}