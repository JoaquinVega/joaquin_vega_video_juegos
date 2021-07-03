using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api_videojuegos.Models;

namespace web_videojuegos.Controllers
{
    public class ConsolasController : Controller
    {
        video_juegos_bd bd = new video_juegos_bd();
        // GET: Consolas
        public ActionResult Index()
        {
            IEnumerable<consola> sistema = bd.consolas;
            return View(bd.consolas);
        }

        // GET: Consolas/Details/5
        public ActionResult Details(int id)
        {
            consola consola_detalles = bd.consolas.Find(id);
            return View(consola_detalles);
        }

        // GET: Consolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consolas/Create
        [HttpPost]
        public ActionResult Create(consola new_consola)
        {
            try
            {
                // TODO: Add insert logic here
                bd.consolas.Add(new_consola);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int id)
        {
            consola consola_detalles = bd.consolas.Find(id);
            return View(consola_detalles);
        }

        // POST: Consolas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, consola consolas)
        {
            try
            {
                // TODO: Add update logic here
                consola consola_detalles = bd.consolas.Find(id);

                consola_detalles.marca = consolas.marca;
                consola_detalles.modelo = consolas.modelo;
                consola_detalles.nueva = consolas.nueva;
                consola_detalles.precio = consolas.precio;
                consola_detalles.stock = consolas.stock;

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int id)
        {
            consola consola_detalles = bd.consolas.Find(id);
            return View(consola_detalles);
        }

        // POST: Consolas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                consola consola_detalles = bd.consolas.Find(id);
                bd.consolas.Remove(consola_detalles);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
