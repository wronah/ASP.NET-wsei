using Formularz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Formularz.Controllers
{
    public class DaneController : Controller
    {
        // GET: DaneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DaneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DaneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DaneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DaneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DaneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DaneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DaneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if(ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            return View();
        }
        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
