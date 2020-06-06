using StartupApi.Data;
using StartupApi.Entities.Categories;
using System.Collections.Generic;
using System.Linq;

namespace StartupApi.Services.Categories
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }

    public class ProductService : IProductService
    {
        private readonly StartupContext _dbContext;

        public ProductService(StartupContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Products;
        }

        public Product GetById(int id)
        {
            return _dbContext.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
