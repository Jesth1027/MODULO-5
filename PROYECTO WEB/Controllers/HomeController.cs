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
        private webEntities2 db = new webEntities2();


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

  

        //



   


    }
}