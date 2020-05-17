using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreApp.BusinessLogic;

namespace StoreApp.Data
{
    //public class Repository<T> : IRepository<T> where T : class
    //{
    //    private readonly StoreAppDbContext _context;

    //    public Repository(StoreAppDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public async Task AddAsync(T entity)
    //    {
    //        _context.Add(entity);
    //        await _context.SaveChangesAsync();
    //        //throw new NotImplementedException();
    //    }

    //    public Task DeleteAsync(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<IEnumerable<T>> GetAllAsync()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<T> GetAsync(int id)
    //    {
    //        _context.
    //        throw new NotImplementedException();
    //    }
    //}
    //public class Repository : IRepository
    //{
    //    private readonly StoreAppDbContext _context;

    //    public Repository(StoreAppDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public Task AddCustomer(BusinessLogic.User customer)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<List<BusinessLogic.User>> GetCustomersAsync(string firstName, string lastName)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<BusinessLogic.Order> GetOrderAsync(int orderID)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<List<BusinessLogic.Order>> GetOrdersByCustAsync(int customerID)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<List<BusinessLogic.Order>> GetOrdersByLocAsync(int locationID)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<IEnumerable<BusinessLogic.Product>> GetProductsAsync()
    //    {
    //        var dataProducts = await _context.Products.ToListAsync();

    //        return dataProducts.Select(p => new BusinessLogic.Product
    //        {
    //            ProductID = p.ProductID,
    //            Name = p.Name,
    //            Price = p.Price
    //        });
    //    }

    //    public async Task<BusinessLogic.Product> GetProductAsync(int? productID)
    //    {
    //        var p = await _context.Products.FirstOrDefaultAsync(product => product.ProductID == productID);

    //        BusinessLogic.Product bp = new BusinessLogic.Product();
    //        bp.ProductID = p.ProductID;
    //        bp.Name = p.Name;
    //        bp.Price = p.Price;

    //        return bp;
    //    }
    //}
}
