using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoMVCIntelYgentes.Models.Datos
{
    public partial class Empleado
    {
        public Empleado()
        {
            Cargo = new HashSet<Cargo>();
            DeptoEmp = new HashSet<DeptoEmp>();
            DeptoJefe = new HashSet<DeptoJefe>();
            Sueldos = new HashSet<Sueldos>();
        }

        public int EmpNo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public bool Genero { get; set; }
        public DateTime FechaContrato { get; set; }

        public virtual ICollection<Cargo> Cargo { get; set; }
        public virtual ICollection<DeptoEmp> DeptoEmp { get; set; }
        public virtual ICollection<DeptoJefe> DeptoJefe { get; set; }
        public virtual ICollection<Sueldos> Sueldos { get; set; }
    }
}
