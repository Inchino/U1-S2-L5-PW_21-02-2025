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

        public static void UpdateProduct(Product updatedProduct)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.Description = updatedProduct.Description;
                existingProduct.CoverImage = updatedProduct.CoverImage;
                existingProduct.AdditionalImage1 = updatedProduct.AdditionalImage1;
                existingProduct.AdditionalImage2 = updatedProduct.AdditionalImage2;
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}

