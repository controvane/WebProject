using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace appCoreMVCFinalIntelyGentes.ViewModels
{
    public class AdminIndex
    {
        public List<IdentityUser> lista1 { get; set; }
        public List<IdentityRole> lista2 { get; set; }
    }
}
