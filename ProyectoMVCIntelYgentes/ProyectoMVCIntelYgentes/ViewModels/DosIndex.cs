using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMVCIntelYgentes.ViewModels
{
    public class DosIndex
    {
        [Display(Name ="Ingrese Numero 1:")]
        public int Num1 { get; set; }
        [Display(Name = "Ingrese Numero 2:")]
        public bool Num2 { get; set; }
        [DataType(DataType.Password)]
        public String Cadena { get; set; }
    }
}
