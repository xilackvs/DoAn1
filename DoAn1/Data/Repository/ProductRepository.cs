using DoAn1.Data.Interfaces;
using DoAn1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MerchShopDbContext context) : base(context)
        {

        }

        public IEnumerable<Product> FindWithThisType(Func<Product, bool> predicate)
        {
            return _context.Products
                .Include(pt => pt.ProductType)
                .Where(predicate);
        }

        public IEnumerable<Product> GetAllWithType()
        {
            return _context.Products.Include(pt => pt.ProductType);
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _context.Products.FirstAsync(e => e.Id == productId);
        }

        public Product GetProductByIDWithType(int id)
        {
            return _context.Set<Product>()
                .Include(pt => pt.ProductType)
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
