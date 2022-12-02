using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoterieCDA.Controllers
{
    public class RulesController : Controller
    {
        // GET: RulesController
        public ActionResult Rules()
        {
            return View();
        }

        // GET: RulesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RulesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RulesController/Create
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

        // GET: RulesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RulesController/Edit/5
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

        // GET: RulesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RulesController/Delete/5
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
