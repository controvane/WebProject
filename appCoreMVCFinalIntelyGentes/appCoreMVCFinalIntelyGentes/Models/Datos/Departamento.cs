using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace appCoreMVCFinalIntelyGentes.Models.Datos
{
    public partial class Departamento
    {
        public Departamento()
        {
            DeptoEmp = new HashSet<DeptoEmp>();
            DeptoJefe = new HashSet<DeptoJefe>();
        }

        public string DeptoNo { get; set; }
        public string DeptoNombre { get; set; }

        public virtual ICollection<DeptoEmp> DeptoEmp { get; set; }
        public virtual ICollection<DeptoJefe> DeptoJefe { get; set; }
    }
}
