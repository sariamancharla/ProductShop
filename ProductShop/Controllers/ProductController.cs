using Microsoft.AspNetCore.Mvc;
using ProductShop.Models;
using System.Collections.Generic;

namespace ProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = Database.GetProduct(slugLink);
            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = Database.GetProducts();
            return View(products);
        }
    }
}
