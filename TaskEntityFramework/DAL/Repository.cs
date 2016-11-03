using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskEntityFramework.Models;

namespace TaskEntityFramework.DAL
{
    public class Repository
    {
        public void AddTypeOfProduct(ProductType type)
        {
            using (var context = new DatabaseContext())
            {
                context.ProductTypes.Add(type);
                context.SaveChanges();
            }
        }
        public void AddProduct(Product product)
        {
            using (var context = new DatabaseContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public ProductType GetProductTypeById(int productTypeID)
        {
            using (var context = new DatabaseContext())
            {
                var productType = context.ProductTypes.Where(f => f.ProductTypeID == productTypeID).SingleOrDefault();
                return (ProductType)productType;
            }
        }
        public List<ProductType> GetProductTypes()
        {
            using (var context = new DatabaseContext())
            {
                return context.ProductTypes.ToList();
            }
        }
        public void UpdateProduct(int productID, string productName)
        {
            using (var context = new DatabaseContext())
            {
                Product product = context.Products.FirstOrDefault(x => x.ProductID == productID);
                product.Name = productName;
                context.SaveChanges();
            }
        }
        public void RemoveProduct(Product product)
        {
            using (var context = new DatabaseContext())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            } 
        }
    }
}