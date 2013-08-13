using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseManagement.Models;
using System.Data.Objects;
using HouseManagement.ViewModels;
using AutoMapper;

namespace HouseManagement.Controllers
{
    public class ExpensesController : Controller
    {
        private HouseModelContainer db = new HouseModelContainer();

        private ObjectQuery<Expense> Expenses
        {
            get
            {
                return db.ITransactions.OfType<Expense>();
            }
        }

        //
        // GET: /Expenses/

        public ActionResult Index()
        {
            return View(Expenses.ToList());
        }

        //
        // GET: /Expenses/Details/5

        public ActionResult Details(int id = 0)
        {
            Expense expense = Expenses.Single(e => e.Id == id) as Expense;
            if (expense == null)
            {
                return HttpNotFound();
            }
            return View(expense);
        }

        //
        // GET: /Expenses/Create

        public ActionResult Create()
        {
            return View(new ExpensesViewModel()
                {
                    Description = "Persil washing up powder",
                    GbpAmount = 9.99M,
                    TransactionDate = new DateTime(2013,7,15),
                    Quantity = 1
                });
        }

        //
        // POST: /Expenses/Create

        [HttpPost]
        public ActionResult Create(ExpensesViewModel expenseViewModel)
        {
            Expense expense = null;

            if (ModelState.IsValid)
            {
                Mapper.CreateMap<ExpensesViewModel, Expense>();
                expense = Mapper.Map<ExpensesViewModel, Expense>(expenseViewModel);
                db.ITransactions.AddObject(expense);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expense);
        }

        //
        // GET: /Expenses/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Expense expense = Expenses.Single(e => e.Id == id) as Expense;
            if (expense == null)
            {
                return HttpNotFound();
            }
            return View(expense);
        }

        //
        // POST: /Expenses/Edit/5

        [HttpPost]
        public ActionResult Edit(Expense expense)
        {
            if (ModelState.IsValid)
            {
                db.ITransactions.Attach(expense);
                db.ObjectStateManager.ChangeObjectState(expense, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }

        //
        // GET: /Expenses/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Expense expense = Expenses.Single(e => e.Id == id) as Expense;
            if (expense == null)
            {
                return HttpNotFound();
            }
            return View(expense);
        }

        //
        // POST: /Expenses/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Expense expense = Expenses.Single(e => e.Id == id) as Expense;
            db.ITransactions.DeleteObject(expense);
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