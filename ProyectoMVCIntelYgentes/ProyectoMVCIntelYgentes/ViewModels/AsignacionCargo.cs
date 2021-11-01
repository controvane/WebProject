using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoMVCIntelYgentes.Models.Datos;
namespace ProyectoMVCIntelYgentes.ViewModels
{
    public class AsignacionCargo
    {
        public Empleado Empleado { get; set; }
        [Required]
        public String Cargo { get; set; }
        public DateTime FechaInicio { get; set; }
        //public List<Cargo> ListaCargos { get; set; }

        //public string CargoSeleccionado { get; set; }

        //public List<SelectListItem> Cargos { get; set; }
    }
}
