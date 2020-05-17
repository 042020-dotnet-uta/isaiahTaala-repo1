using Microsoft.EntityFrameworkCore;
using Xunit;
using StoreApp.BusinessLogic;
using StoreApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace XUnitTests
{
    public class RepositoryTests
    {
        // https://www.carlrippon.com/testing-ef-core-repositories-with-xunit-and-an-in-memory-db/
        [Fact]
        public async Task Add_Product()
        {
            var repo = GetInMemoryProductRepository();
            var product = new StoreApp.BusinessLogic.Product()
            {
                ProductID = 1,
                Name = "soap",
                Price = 40.00M
            };

            //Person savedPerson = sut.Add(person);
            await repo.AddAsync(product);

            var foundProduct = await repo.GetAsync(1);

            Assert.Equal(1, foundProduct.ProductID);
            Assert.Equal("soap", foundProduct.Name);
            Assert.Equal(40.00M, foundProduct.Price);
        }

        [Fact]
        public async Task Get_AllProducts()
        {
            var repo = GetInMemoryProductRepository();
            var product1 = new StoreApp.BusinessLogic.Product()
            {
                ProductID = 1,
                Name = "soap",
                Price = 40.00M
            };
            var product2 = new StoreApp.BusinessLogic.Product()
            {
                ProductID = 2,
                Name = "shampoo",
                Price = 50.00M
            };

            await repo.AddAsync(product1);
            await repo.AddAsync(product2);

            var foundProducts = await repo.GetAllAsync();

            Assert.Equal(2, foundProducts.Count());
        }

        private ProductRepository GetInMemoryProductRepository()
        {
            DbContextOptions<StoreAppDbContext> options;
            var builder = new DbContextOptionsBuilder<StoreAppDbContext>();
            builder.UseInMemoryDatabase("InMemoryProductTestDB");
            options = builder.Options;
            StoreAppDbContext context = new StoreAppDbContext(options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            return new ProductRepository(context);
        }
    }
}