using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoMandeha.Models;

namespace TodoMandeha.Controllers
{
    public class TacheController : Controller
    {
        // GET: Tache
        public ActionResult TaskList()
        {
            
            return View(DBConnexion.retrouverTaches(Session["username"].ToString()));
        }

        // GET: Tache/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

      
        // POST: Tache/Create
        [HttpPost]
       
        public ActionResult Create(string username, string description, bool state)
        {
          
                var tache = new Tache();
                tache.Username = Session["username"].ToString();
                tache.Description = description;
                tache.State = state;

                DBConnexion.AjoutTache(tache);

            return RedirectToRoute("TaskList");
            
               
               
        }

        // GET: Tache/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tache/Edit/5
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

        // GET: Tache/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tache/Delete/5
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
