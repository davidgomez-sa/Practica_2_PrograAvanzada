using Practica_2_PrograAvanzada.Entities;
using Practica_2_PrograAvanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_2_PrograAvanzada.Controllers
{
    public class HomeController : Controller
    {
        HomeModel homeM = new HomeModel();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult consultaVehiculos()
        {
            var respuesta = homeM.ConsultarVehiculos();

            ViewBag.msj = "";
            return View(respuesta);
        }

        [HttpGet]
        public ActionResult registroVendedores()
        {
            ViewBag.msj = "";
            return View();
        }

        [HttpPost]
        public ActionResult registroVendedores(Vendedores entity)
        {
            var respuesta = homeM.RegistrarVendedor(entity);

            if (respuesta)
            {
                ViewBag.msj = "Su información se ha registrado con exito!";
                return View();
            }
            else
            {
                ViewBag.msj = "Error! Su información no se ha registrado";
                return View();
            }
        }

        [HttpGet]
        public ActionResult registroVehiculos()
        {
            ViewBag.msj = "";
            return View();
        }

        [HttpPost]
        public ActionResult registroVehiculos(Vehiculos entity)
        {
            var respuesta = homeM.RegistrarVehiculo(entity);

            if (respuesta)
            {
                ViewBag.msj = "Su vehículo se ha registrado con exito!";
                return View();
            }
            else
            {
                ViewBag.msj = "Error! Su vehículo no se ha registrado";
                return View();
            }
        }
    }
}