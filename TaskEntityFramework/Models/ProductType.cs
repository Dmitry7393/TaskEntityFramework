using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskEntityFramework.Models
{
    public class ProductType
    {
        public int ProductTypeID { get; set; }
        public string TypeOfProduct { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}