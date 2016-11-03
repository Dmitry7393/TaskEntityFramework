using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskEntityFramework.DAL;
using TaskEntityFramework.Models;

namespace TaskEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        Repository repository;
        DropDownList dropDownList;
        // GET: Home
        public HomeController()
        {
            repository = new Repository();
            dropDownList = new DropDownList();
        }
        private DropDownList getList()
        {
            List<SelectListItem> listSelectItem = new List<SelectListItem>();
            foreach(var productType in repository.GetProductTypes())
            {
                listSelectItem.Add(new SelectListItem() { Value = Convert.ToString(productType.ProductTypeID), Text = productType.TypeOfProduct });
            }
            dropDownList.TypesOfProduct = new SelectList(listSelectItem, "Value", "Text");
            return dropDownList;
        }
        public ActionResult Index()
        {
            return View(getList());
        }
        [HttpPost]
        public ActionResult AddNewTypeOfProduct(FormCollection formCollection)
        {
            repository.AddTypeOfProduct(new ProductType() { TypeOfProduct = formCollection["product_type"] });
            return RedirectToAction("Index", getList());
        }
        [HttpPost]
        public ActionResult AddProduct(DropDownList type, FormCollection formCollection)
        {
            ProductType typeOfProduct = repository.GetProductTypeById(type.selectedId);
            repository.AddProduct(new Product() { Name = formCollection["product"],
                                                 productType = typeOfProduct });

            return RedirectToAction("Index", getList());
        }
    }
}