using ATKSmartApi.Data;
using ATKSmartApi.Entities.Categories;
using System.Collections.Generic;
using System.Linq;

namespace ATKSmartApi.Services.Categories
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> PostSupplierByStore();
        Supplier GetById(int id);
    }

    public class SupplierService : ISupplierService
    {
        private readonly ATKSmartContext _dbContext;

        public SupplierService(ATKSmartContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Supplier> PostSupplierByStore()
        {
            return _dbContext.Suppliers;
        }

        public Supplier GetById(int id)
        {
            return _dbContext.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        }
    }
}
