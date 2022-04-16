using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_Mahasiswa_FIX.DataContext;
using CRUD_Mahasiswa_FIX.Models;

namespace CRUD_Mahasiswa_FIX.Controllers
{
    public class DatamhsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Datamhs
        public ActionResult Index()
        {
            return View(db.datamhsObj.ToList());
        }

        // GET: Datamhs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datamhs datamhs = db.datamhsObj.Find(id);
            if (datamhs == null)
            {
                return HttpNotFound();
            }
            return View(datamhs);
        }

        // GET: Datamhs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Datamhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mhs_id,mhs_nama,mhs_prodi,mhs_nohp")] Datamhs datamhs)
        {
            if (ModelState.IsValid)
            {
                db.datamhsObj.Add(datamhs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datamhs);
        }

        // GET: Datamhs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datamhs datamhs = db.datamhsObj.Find(id);
            if (datamhs == null)
            {
                return HttpNotFound();
            }
            return View(datamhs);
        }

        // POST: Datamhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mhs_id,mhs_nama,mhs_prodi,mhs_nohp")] Datamhs datamhs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datamhs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datamhs);
        }

        // GET: Datamhs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datamhs datamhs = db.datamhsObj.Find(id);
            if (datamhs == null)
            {
                return HttpNotFound();
            }
            return View(datamhs);
        }

        // POST: Datamhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Datamhs datamhs = db.datamhsObj.Find(id);
            db.datamhsObj.Remove(datamhs);
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
