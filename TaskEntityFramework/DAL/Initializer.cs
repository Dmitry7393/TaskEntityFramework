using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskEntityFramework.Models;

namespace TaskEntityFramework.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            ProductType typeVegetables = new ProductType() {  TypeOfProduct="Vegetables" };

            context.ProductTypes.Add(typeVegetables);
            context.SaveChanges();

            Product product = new Product() { Name = "mushroom",  productType=typeVegetables };

            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}