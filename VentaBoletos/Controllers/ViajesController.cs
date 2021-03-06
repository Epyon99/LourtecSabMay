﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VentaBoletos.Models;

namespace VentaBoletos.Controllers
{
    public class ViajesController : Controller
    {
        private VentaBoletosContext db = new VentaBoletosContext();

        //[Route("Viaje/{tipoBusqueda}/{valor1}/{valor2}")]
        public ActionResult Buscar(int tipoBusqueda, string valor1, string valor2)
        {
            ViewBag.TipoBusqueda = tipoBusqueda;
            ViewBag.valor1 = valor1;
            ViewBag.valor2 = valor2;
            return View();
        }

        // GET: Viajes
        public ActionResult Index()
        {
            //var viajes = db.Viajes.Include(v => v.Trayecto);
            return View(db.Viajes.ToList());
        }

        // GET: Viajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viaje viaje = db.Viajes.Find(id);
            if (viaje == null)
            {
                return HttpNotFound();
            }
            return View(viaje);
        }

        // GET: Viajes/Create
        public ActionResult Create()
        {
            ViewBag.Hola = "Hola mundo";
            TempData.Add("Hola", "Valor");
            ViewBag.TrayectoId = new SelectList(db.Trayectoes, "TrayectoId", "TrayectoId");
            return View();
        }

        // POST: Viajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ViajeId,VendedorId,CategoriaId,Puesto,PuertaSalida,HoraSalida,HoraEstimadaLlegada,Unidad,Precio,NumeroViaje,TrayectoId")] Viaje viaje)
        {
            if (ModelState.IsValid)
            {
                db.Viajes.Add(viaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TrayectoId = new SelectList(db.Trayectoes, "TrayectoId", "TrayectoId", viaje.TrayectoId);
            return View(viaje);
        }

        // GET: Viajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viaje viaje = db.Viajes.Find(id);
            if (viaje == null)
            {
                return HttpNotFound();
            }
            ViewBag.TrayectoId = new SelectList(db.Trayectoes, "TrayectoId", "TrayectoId", viaje.TrayectoId);
            return View(viaje);
        }

        // POST: Viajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ViajeId,VendedorId,CategoriaId,Puesto,PuertaSalida,HoraSalida,HoraEstimadaLlegada,Unidad,Precio,NumeroViaje,TrayectoId")] Viaje viaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TrayectoId = new SelectList(db.Trayectoes, "TrayectoId", "TrayectoId", viaje.TrayectoId);
            return View(viaje);
        }

        // GET: Viajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viaje viaje = db.Viajes.Find(id);
            if (viaje == null)
            {
                return HttpNotFound();
            }
            return View(viaje);
        }

        // POST: Viajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Viaje viaje = db.Viajes.Find(id);
            db.Viajes.Remove(viaje);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
