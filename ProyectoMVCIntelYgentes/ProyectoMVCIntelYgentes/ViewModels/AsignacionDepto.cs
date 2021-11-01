using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoMVCIntelYgentes.Models.Datos;
namespace ProyectoMVCIntelYgentes.ViewModels
{
    public class AsignacionDepto
    {
        public Empleado Empleado { get; set; }
        public List<Departamento> ListaDeptos { get; set; }

        public string DeptoSeleccionado { get; set; }

        public List<SelectListItem> Deptos { get; set; }
    }
}
