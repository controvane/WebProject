using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoMVCIntelYgentes.Models.Datos
{
    public partial class DeptoJefe
    {
        public int EmpleadoEmpNo { get; set; }
        public string DepartamentoDeptoNo { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual Departamento DepartamentoDeptoNoNavigation { get; set; }
        public virtual Empleado EmpleadoEmpNoNavigation { get; set; }
    }
}
