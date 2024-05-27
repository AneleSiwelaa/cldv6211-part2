using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft_Emporium.Controllers
{
    public class MyWork : Controller
    {
        // GET: MyWork
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyWork/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyWork/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyWork/Create
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

        // GET: MyWork/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyWork/Edit/5
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

        // GET: MyWork/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyWork/Delete/5
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
