using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingScoreTracker.Controllers
{
    public class FrameScoreController : Controller
    {
        // GET: FrameScoreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FrameScoreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FrameScoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FrameScoreController/Create
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

        // GET: FrameScoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FrameScoreController/Edit/5
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

        // GET: FrameScoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FrameScoreController/Delete/5
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
