using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMVCIntelYgentes.Models.Datos;
using ProyectoMVCIntelYgentes.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoMVCIntelYgentes.Controllers
{
    public class AsignacionController : Controller
    {
        public IActionResult Index()
        {
            rrhhContext Datos = new rrhhContext();
            List<Empleado> lista = Datos.Empleado.ToList();
            return View(lista);
        }

        public IActionResult Cargo(int id)
        {
            rrhhContext Datos = new rrhhContext();
            Empleado empleado = Datos.Empleado.Find(id);
            AsignacionCargo vista = new AsignacionCargo();
            vista.Empleado = empleado;
            vista.FechaInicio = DateTime.Now;
            return View(vista);
        }
        [BindProperty]
        public AsignacionCargo Datos { get; set; }
        public IActionResult RegistrarCargo()
        {
            return View();
        }
            public IActionResult Departamento(int id)
        {
            rrhhContext Datos = new rrhhContext();
            Empleado empleado = Datos.Empleado.Find(id);
            List<Departamento> listaDeptos = Datos.Departamento.ToList();
            AsignacionDepto vista = new AsignacionDepto();
            vista.Empleado = empleado;
            vista.ListaDeptos = listaDeptos;
            vista.Deptos = new List<SelectListItem>();
            foreach (Departamento depto in listaDeptos)
            {
                SelectListItem item = new SelectListItem(depto.DeptoNombre, depto.DeptoNo);
                vista.Deptos.Add(item);
            }
            return View(vista);
        }
    }
}
