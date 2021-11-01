using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVCIntelYgentes.Controllers
{
    public class UnoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["mensaje"] = "Mensaje uno";
            ViewBag.mensaje1 = "Mensaje Dos";
            return View();
        }
    }
}
