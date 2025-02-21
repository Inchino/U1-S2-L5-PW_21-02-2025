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
                TempData["SuccessMessage"] = "Prodotto aggiunto con successo!";
                return RedirectToAction("Index", "Home");
            }

            TempData["ErrorMessage"] = "Errore nell'aggiunta del prodotto.";
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = ProductRepository.GetProductById(id);
            if (product == null)
            {
                TempData["ErrorMessage"] = "Prodotto non trovato.";
                return RedirectToAction("Index", "Home");
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.UpdateProduct(product);
                TempData["SuccessMessage"] = "Prodotto modificato con successo.";
                return RedirectToAction("Details", new { id = product.Id });
            }

            TempData["ErrorMessage"] = "Errore nella modifica del prodotto.";
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = ProductRepository.GetProductById(id);
            if (product == null)
            {
                TempData["ErrorMessage"] = "Prodotto non trovato.";
                return RedirectToAction("Index", "Home");
            }

            ProductRepository.DeleteProduct(id);
            TempData["SuccessMessage"] = "Prodotto eliminato con successo.";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {
            var product = ProductRepository.GetProductById(id);
            if (product == null)
            {
                TempData["ErrorMessage"] = "Prodotto non trovato.";
                return RedirectToAction("Index", "Home");
            }

            return View(product);
        }
    }
}
