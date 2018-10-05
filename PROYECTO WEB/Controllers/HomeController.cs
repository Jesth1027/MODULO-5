using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PROYECTO_WEB.Models;

namespace PROYECTO_WEB.Controllers
{
    public class HomeController : Controller
    {
        private webEntities1 db = new webEntities1();

        public ActionResult Index()
        {
            return View("Login");
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

        public ActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Login([Bind(Include = "usuario1,password")] usuario usuario)
        {
            buscar_user_Result u = db.buscar_user(usuario.usuario1, usuario.password).FirstOrDefault();

            //insertar
            //try
            //{
            //    usuario.id = 2;
            //    usuario.nombre = "Tarzan";
            //    usuario.puesto = "Rey de la selva";

            //    db.usuario.Add(usuario);
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("Eror", ex.Message);
            //    return View();
            //}


            if (u == null)//si no existe el usuario
            {
                ModelState.AddModelError("Eror", "Usuario o Contraseña Incorrectos.");
                return View();
            }

            return View();//redirigir a vista con layout menu
        }

    }
}