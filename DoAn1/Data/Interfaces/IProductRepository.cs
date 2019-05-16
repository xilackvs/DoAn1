using DoAn1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Interfaces
{
    public interface IProductRepository: IRepository<Product>
    {
        IEnumerable<Product> GetAllWithType();
        IEnumerable<Product> FindWithThisType(Func<Product, bool> predicate);
        Product GetProductByIDWithType(int id);
        Task<Product> GetProductByIdAsync(int productId);
    }
}
