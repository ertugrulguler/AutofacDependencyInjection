using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDependencyInjection.Models
{
    public class Product : IProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Product AddProduct(Product item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product item)
        {
            throw new NotImplementedException();
        }
    }
}