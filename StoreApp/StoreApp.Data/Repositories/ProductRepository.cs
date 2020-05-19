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
    public class ProductRepository : IRepository<BusinessLogic.Product>
    {
        private readonly StoreAppDbContext _context;

        public ProductRepository(StoreAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(BusinessLogic.Product product)
        {
            var dataProduct = new Product()
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price
            };
            _context.Add(dataProduct);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BusinessLogic.Product>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products.Select(p => new BusinessLogic.Product
            {
                ProductID = p.ProductID,
                Name = p.Name,
                Price = p.Price
            });
        }

        public async Task<BusinessLogic.Product> GetAsync(int id)
        {
            var product = await _context.Products.FirstAsync(p => p.ProductID == id);
            return new BusinessLogic.Product()
            { 
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price
            };
        }

        public Task<BusinessLogic.Product> GetAsync(BusinessLogic.Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
