using Microsoft.AspNetCore.Mvc;
using S2_L5_PW.Models;

namespace S2_L5_PW.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(product);
                return RedirectToAction("Index", "Home");
            }
            return View(product);
        }

        public IActionResult Details(int id)
        {
            var product = ProductRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
