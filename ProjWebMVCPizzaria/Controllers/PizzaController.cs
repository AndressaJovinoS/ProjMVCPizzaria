using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Model;

namespace ProjWebMVCPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            var list = this.Crud().Select();
            return View(list);
        }

        public ActionResult Create()
		{
            return View();
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                this.Crud().Insert(pizza);
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Edit(int id)
        {
            var pizza = this.Crud().SelectById(id);
            return View(pizza);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                this.Crud().Update(pizza);
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Details(int id)
        {
            var pizza = this.Crud().SelectById(id);
            return View(pizza);
        }

        public ActionResult Delete(int id)
        {
            var pizza = this.Crud().SelectById(id);
            return View(pizza);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            this.Crud().Delete(id);
            return RedirectToAction("Index");
        }

        private IPizzaDB Crud()
        {
            return new PizzaDB();
        }
    }
}