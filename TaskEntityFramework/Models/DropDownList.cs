using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskEntityFramework.Models
{
    public class DropDownList
    {
        public int selectedId { get; set; }
        public SelectList TypesOfProduct;
    }
}