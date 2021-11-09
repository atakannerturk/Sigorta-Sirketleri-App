using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    public class PoliceController : Controller
    {
        // GET: PoliceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PoliceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PoliceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceController/Create
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

        // GET: PoliceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PoliceController/Edit/5
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

        // GET: PoliceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PoliceController/Delete/5
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
