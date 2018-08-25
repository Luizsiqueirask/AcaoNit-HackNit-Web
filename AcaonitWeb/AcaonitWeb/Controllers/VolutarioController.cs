using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcaonitWeb.Controllers
{
    public class VolutarioController : Controller
    {
        // GET: Volutario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Volutario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Volutario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Volutario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Volutario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Volutario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Volutario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Volutario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
