using ATKSmartApi.Data;
using ATKSmartApi.Entities.Categories;
using System.Collections.Generic;
using System.Linq;

namespace ATKSmartApi.Services.Categories
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }

    public class ProductService : IProductService
    {
        private readonly ATKSmartContext _dbContext;

        public ProductService(ATKSmartContext dbContext)
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
