﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class HomeController : Controller
    {
        
        public TestDAO _testDAO;
        private ClinicaNetDBEntities context;

        public HomeController()
        {
            _testDAO = new TestDAO();
            context = new ClinicaNetDBEntities();
        }

        public ActionResult Index()
        {
         List<Usuario> prueba = _testDAO.listar();
            return View(prueba);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}