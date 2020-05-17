using Microsoft.EntityFrameworkCore;
using Xunit;
using StoreApp.BusinessLogic;
using StoreApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace XUnitTests
{
    public class ControllerTests
    {
        public async Task Add_Product()
        {
            var repo = GetInMemoryProductRepository();
            var product = new StoreApp.BusinessLogic.Product()
            {
                ProductID = 1,
                Name = "soap",
                Price = 40.00M
            };

            await repo.AddAsync(product);

            var foundProduct = await repo.GetAsync(1);

            Assert.Equal(1, foundProduct.ProductID);
            Assert.Equal("soap", foundProduct.Name);
            Assert.Equal(40.00M, foundProduct.Price);
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
