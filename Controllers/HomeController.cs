using Microsoft.AspNetCore.Mvc;
using Aflevering1.Models;
namespace Aflevering1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
                return View("Thanks", product);
            }
            else
            {
                return View();
            }
        }
        
        public ViewResult ListProducts()
        {
            return View(Repository.Products);
        }
    }
}