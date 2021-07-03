using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api_videojuegos.Models;

namespace web_videojuegos.Controllers
{
    public class MandosController : Controller
    {
        video_juegos_bd bd = new video_juegos_bd();
        // GET: Mandos
        public ActionResult Index()
        {
            IEnumerable<mando> sistema = bd.mandos;
            //Al llamar a la vista debemos agregar los mandos
            return View(bd.mandos);
        }

        // GET: Mandos/Details/5
        public ActionResult Details(int id)
        {
            mando mando_detalles = bd.mandos.Find(id);
            return View(mando_detalles);
        }

        // GET: Mandos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mandos/Create
        [HttpPost]
        public ActionResult Create(mando new_mando)
        {
            try
            {
                bd.mandos.Add(new_mando);
                bd.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Edit/5
        public ActionResult Edit(int id)
        {
            mando mando_detalles = bd.mandos.Find(id);
            return View(mando_detalles);
        }

        // POST: Mandos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, mando mandos)
        {
            try
            {
                // TODO: Add update logic here
                mando mando_detalles = bd.mandos.Find(id);

                mando_detalles.compatibilidad = mandos.compatibilidad;
                mando_detalles.marca = mandos.marca;
                mando_detalles.modelo = mandos.modelo;
                mando_detalles.precio = mandos.precio;
                mando_detalles.stock = mandos.stock;

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Delete/5
        public ActionResult Delete(int id)
        {
            mando mando_detalles = bd.mandos.Find(id);
            return View(mando_detalles);
        }

        // POST: Mandos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mando mando_detalles = bd.mandos.Find(id);
                bd.mandos.Remove(mando_detalles);
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
