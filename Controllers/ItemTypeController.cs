using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseManagement.Models;

namespace HouseManagement.Controllers
{
    public class ItemTypeController : Controller
    {
        private HouseModelContainer db = new HouseModelContainer();

        //
        // GET: /ItemType/

        public ActionResult Index()
        {
            return View(db.ItemTypes.ToList());
        }

        //
        // GET: /ItemType/Details/5

        public ActionResult Details(int id = 0)
        {
            ItemType itemtype = db.ItemTypes.Single(i => i.Id == id);
            if (itemtype == null)
            {
                return HttpNotFound();
            }
            return View(itemtype);
        }

        //
        // GET: /ItemType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ItemType/Create

        [HttpPost]
        public ActionResult Create(ItemType itemtype)
        {
            if (ModelState.IsValid)
            {
                db.ItemTypes.AddObject(itemtype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemtype);
        }

        //
        // GET: /ItemType/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ItemType itemtype = db.ItemTypes.Single(i => i.Id == id);
            if (itemtype == null)
            {
                return HttpNotFound();
            }
            return View(itemtype);
        }

        //
        // POST: /ItemType/Edit/5

        [HttpPost]
        public ActionResult Edit(ItemType itemtype)
        {
            if (ModelState.IsValid)
            {
                db.ItemTypes.Attach(itemtype);
                db.ObjectStateManager.ChangeObjectState(itemtype, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemtype);
        }

        //
        // GET: /ItemType/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ItemType itemtype = db.ItemTypes.Single(i => i.Id == id);
            if (itemtype == null)
            {
                return HttpNotFound();
            }
            return View(itemtype);
        }

        //
        // POST: /ItemType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemType itemtype = db.ItemTypes.Single(i => i.Id == id);
            db.ItemTypes.DeleteObject(itemtype);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}