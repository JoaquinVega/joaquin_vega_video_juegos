using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api_videojuegos.Models;

namespace web_videojuegos.Controllers
{
    public class JuegosController : Controller
    {
        video_juegos_bd bd = new video_juegos_bd();
        // GET: Juegos
        public ActionResult Index()
        {
            IEnumerable<juego> sistema = bd.juegos;
            return View(bd.juegos);
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int id)
        {
            juego juego_detalles = bd.juegos.Find(id);
            return View(juego_detalles);
        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(juego new_juego)
        {
            try
            {
                bd.juegos.Add(new_juego);
                bd.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int id)
        {
            juego juego_detalles = bd.juegos.Find(id);
            return View(juego_detalles);
        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, juego juegos)
        {
            try
            {
                // TODO: Add update logic here
                juego juego_detalles = bd.juegos.Find(id);

                juego_detalles.anio = juegos.anio;
                juego_detalles.nombre = juegos.nombre;
                juego_detalles.plataforma = juegos.plataforma;
                juego_detalles.precio = juegos.precio;
                juego_detalles.restriccion = juegos.restriccion;
                juego_detalles.stock = juegos.stock;

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int id)
        {
            juego juego_detalles = bd.juegos.Find(id);
            return View(juego_detalles);
        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                juego juego_detalles = bd.juegos.Find(id);
                bd.juegos.Remove(juego_detalles);
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
