﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoMandeha.Models;

namespace TodoMandeha.Controllers
{
    public class UtilisateurController : Controller
    {
        [HttpGet]
        public ActionResult Inscription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inscription(Utilisateur utilisateur)
        {
            if (utilisateur.Username != null)
            {
                DBConnexion.InscriptionUtilisateur(utilisateur);
            }
            return Content($"<h1>Bonjour, {utilisateur.Username}. Bienvenue! </h1>");
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Authentification(Utilisateur utilisateur)
        {
            if (DBConnexion.VerifierUtilisateur(utilisateur))
            {
                Session["username"] = utilisateur.Username;
                return RedirectToRoute("TaskList");
            }
            else
            {
                return Content("NON CONNECTE");
            }
        }

        // GET: Utilisateur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Utilisateur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Utilisateur/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Utilisateur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Utilisateur/Edit/5
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

        // GET: Utilisateur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Utilisateur/Delete/5
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