using AW.Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AW.Demo1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.ProductoName = "Visual Studio c#";
            ViewBag.Credit = 5;
            ViewBag.Inicio = DateTime.Now;
            return View();
        }

        public ActionResult IndexModel()
        {
            var prod = new Product();
            prod.ID = 100;
            prod.name = "VS TFS";
            prod.Price = 200;
            prod.Stock = 10;

            return View(prod);
        }

        public ActionResult Listado(string filterByName)
        {

            filterByName = String.IsNullOrWhiteSpace(filterByName) ? "" : filterByName;
            var products = GetProducts();
            products = (from p in products
                       where p.name.ToUpper().Contains(filterByName.ToUpper())
                       select p).ToList();
            ViewBag.Productos = products;

            return View();
        }

        public ActionResult ListadoModel(string filterByName)
        {

            filterByName = String.IsNullOrWhiteSpace(filterByName) ? "" : filterByName;
            var products = GetProducts();
            //Linq
            products = (from p in products
                        where p.name.ToUpper().Contains(filterByName.ToUpper())
                        select p).ToList();
            
            return View(products);
        }
        private List<Product> GetProducts()
        {
            var result = new List<Product>();
            result.Add(new Product
            {
                ID=1,
                name ="PC HP",
                Price = 100,
                Stock =20
            });

            result.Add(new Product
            {
                ID = 2,
                name = "Monitor LG",
                Price = 180,
                Stock = 30
            });

            result.Add(new Product
            {
                ID = 3,
                name = "Impresora Canon",
                Price = 40,
                Stock = 50
            });

            result.Add(new Product
            {
                ID = 4,
                name = "Laptop Toshiba",
                Price = 70,
                Stock = 10
            });

            return result;

        }
    }
}