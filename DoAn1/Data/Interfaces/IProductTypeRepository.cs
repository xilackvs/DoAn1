using DoAn1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Interfaces
{
    public interface IProductTypeRepository: IRepository<ProductType>
    {
        ProductType GetProductTypeByIDWithProduct(int id);
        IEnumerable<ProductType> GetAllWithProduct();
    }
}
