using DoAn1.Data.Interfaces;
using DoAn1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Repository
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(MerchShopDbContext context): base (context)
        {

        }

        public IEnumerable<ProductType> GetAllWithProduct()
        {
            return _context.ProductTypes.Include(p => p.Products);
        }

        public ProductType GetProductTypeByIDWithProduct(int id)
        {
            return _context.Set<ProductType>().Include(p => p.Products).FirstOrDefault(pt => pt.Id == id);
        }
    }
}
