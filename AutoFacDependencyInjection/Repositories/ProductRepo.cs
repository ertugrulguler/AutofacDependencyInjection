using AutoFacDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDependencyInjection.Repositories
{
    public class ProductRepo : IProduct
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepo()
        {
            AddProduct(new Product { Name = "Bilgisayar", Category = "Elektronik", Price = 4500 });
            AddProduct(new Product { Name = "PS4", Category = "Elektronik", Price = 3500 });
            AddProduct(new Product { Name = "Telefon", Category = "Elektronik", Price = 4500 });

        }
        public Product AddProduct(Product item)
        {
            if (item==null)
            {
                throw new ArgumentNullException("item");
            }

            item.ID = _nextId++;
            products.Add(item);
            return item;
        }

        public bool DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(i => i.ID == id);
            products.Remove(product);
            return true;

        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            var product = products.FirstOrDefault(i => i.ID == id);
            return product;
        }

        public bool UpdateProduct(Product item)
        {
            if (item==null)
            {
                throw new ArgumentNullException("item");
            }

            int index = products.FindIndex(i => i.ID == item.ID);
            if (index==-1)
            {
                return false;
            }

            products.RemoveAt(index);
            products.Add(item);

            return true;
        }
    }
}