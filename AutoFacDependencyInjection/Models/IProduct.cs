using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacDependencyInjection.Models
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        Product GetProductById(int id);
        Product AddProduct(Product item);
        bool UpdateProduct(Product item);
        bool DeleteProduct(int id);
    }
}
