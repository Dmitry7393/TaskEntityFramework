using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskEntityFramework.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        
        public virtual ProductType productType { get; set; }
    }
}