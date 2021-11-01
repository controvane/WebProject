using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMVCIntelYgentes.ViewModels;

namespace ProyectoMVCIntelYgentes.Controllers
{
    public class DosController : Controller
    {
        public IActionResult Index()
        {
            DosIndex objeto = new DosIndex();
            objeto.Num1 = 0;
            objeto.Num2 = true;
            return View(objeto);
        }
        public IActionResult Procesar()
        {
            return View();
        }
    }
}
