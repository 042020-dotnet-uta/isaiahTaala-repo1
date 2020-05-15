using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreApp.BusinessLogic;

namespace StoreApp.Data
{
    public class Repository : IRepository
    {
        private readonly StoreAppDbContext _context;

        public Repository(StoreAppDbContext context)
        {
            _context = context;
        }

        public Task AddCustomer(BusinessLogic.User customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<BusinessLogic.User>> GetCustomersAsync(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessLogic.Order> GetOrderAsync(int orderID)
        {
            throw new NotImplementedException();
        }

        public Task<List<BusinessLogic.Order>> GetOrdersByCustAsync(int customerID)
        {
            throw new NotImplementedException();
        }

        public Task<List<BusinessLogic.Order>> GetOrdersByLocAsync(int locationID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BusinessLogic.Product>> GetProductsAsync()
        //public async Task<List<BusinessLogic.Product>> GetProductsAsync()
        {
            //repository.Products.ToListAsync()

            //throw new NotImplementedException();
            var dataProducts = await _context.Products.ToListAsync();
            //List<BusinessLogic.Product> businessProducts = new List<BusinessLogic.Product>();
            //foreach (Product p in dataProducts)
            //{
            //    BusinessLogic.Product bp = new BusinessLogic.Product();
            //    bp.ProductID = p.ProductID;
            //    bp.Name = p.Name;
            //    bp.Price = p.Price;
            //    businessProducts.Add(bp);
            //}
            //return businessProducts;
            return dataProducts.Select(p => new BusinessLogic.Product
            {
                ProductID = p.ProductID,
                Name = p.Name,
                Price = p.Price
            });
        }

        public Task<BusinessLogic.Product> GetProductAsync(int? productID)
        {
            //await _repository.Products
            //    .FirstOrDefaultAsync(m => m.ProductID == id);
            throw new NotImplementedException();
        }
    }
}
