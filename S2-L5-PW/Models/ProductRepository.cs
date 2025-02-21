using System;

using System.Collections.Generic;
using System.Linq;

namespace S2_L5_PW.Models
{
    public static class ProductRepository
    {
        private static List<Product> products = new List<Product>();
        private static int nextId = 1;

        public static List<Product> GetAllProducts() => products;

        public static Product GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);

        public static void AddProduct(Product product)
        {
            product.Id = nextId++;
            products.Add(product);
        }
    }
}

