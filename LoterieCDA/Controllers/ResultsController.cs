using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoterieCDA.Controllers
{
    public class ResultsController : Controller
    {
        // GET: ResultsController
        public ActionResult Results()
        {
            return View();
        }

        // GET: ResultsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResultsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResultsController/Create
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

        // GET: ResultsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResultsController/Edit/5
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

        // GET: ResultsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResultsController/Delete/5
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
    }
}
