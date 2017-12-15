using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using poc1.Service;

namespace poc1.Controllers
{
    public class VacationController : Controller
    {
        MesService mes = new MesService();
        // GET: Vacation
        public ActionResult Index(DateTime fecha, int dias)
        {
            DateTime dateTime = DateTime.Now;
            var list = mes.GetListVacaton(fecha, dias);
            return View(list);
        }

        // GET: Vacation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vacation/Create
        public ActionResult Create()
        {
            DateTime dateTime = DateTime.Now;
            var list = mes.GetListVacaton(dateTime, 20);
            return View(list);
        }

        // POST: Vacation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index),new { fecha=DateTime.Now,dias=20 });
            }
            catch
            {
                return View();
            }
        }

        // GET: Vacation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vacation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Vacation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vacation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}