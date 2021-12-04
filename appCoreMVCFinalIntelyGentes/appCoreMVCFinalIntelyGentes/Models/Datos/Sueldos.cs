using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace appCoreMVCFinalIntelyGentes.Models.Datos
{
    public partial class Sueldos
    {
        public int EmpNo { get; set; }
        public DateTime DesdeFecha { get; set; }
        public int Sueldo { get; set; }
        public DateTime? HastaFecha { get; set; }

        public virtual Empleado EmpNoNavigation { get; set; }
    }
}
