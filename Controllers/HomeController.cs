using Microsoft.AspNetCore.Mvc;
using Aflevering1.Models;
namespace Aflevering1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ProductAdded = false;
            return View();
        }

        [HttpGet]
        public ViewResult ShoppingListForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ShoppingListForm(Product product)
        {
            if (ModelState.IsValid)
            {
                Repository.AddProduct(product);
                ViewBag.ProductAdded = true;
            }
            else
            {
                ViewBag.ProductAdded = false;
            }
            return View();
        }

        [HttpPost]
        public IActionResult RemoveProduct(string productName)
        {
            var productToRemove = Repository.Products.FirstOrDefault(product => product.Name == productName);
            if (productToRemove != null)
            {
                Repository.RemoveProduct(productToRemove);
            }
            return RedirectToAction("ListProducts");
        }

        [HttpGet]
        public ViewResult ListProducts()
        {
            return View(Repository.Products);
        }
    }
}