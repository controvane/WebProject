using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMVCIntelYgentes.Models.Datos;

namespace ProyectoMVCIntelYgentes.Controllers
{
    public class AsignacionDepController : Controller
    {
        public IActionResult Index()
        {
            rrhhContext Datos = new rrhhContext();
            List<Departamento> lista = Datos.Departamento.ToList();
            return View(lista);
        }
    }
}
