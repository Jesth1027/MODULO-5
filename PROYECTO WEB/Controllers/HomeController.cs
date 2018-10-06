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


        public ActionResult Login()
        {
            return View();
        }



        public ActionResult cheque()
        {
           return PartialView("~/views/gest_cheque/Index.cshtml");
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "usuario1,password")] usuario usuario)
        {
            buscar_user_Result u = db.buscar_user(usuario.usuario1, usuario.password).FirstOrDefault();

            

            if (u == null)//si no existe el usuario
            {
                ModelState.AddModelError("Eror", "Usuario o Contraseña Incorrectos.");
                return View();
            }
            Session["usuario"] = u.usuario;
            Session["id"] = u.id;
            Session["nombre"] = u.nombre;
            Session["puesto"] = u.puesto;
            return View("menu");//redirigir a vista con layout menu
        }

  





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


    }
}