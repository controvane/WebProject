using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace appCoreMVCFinalIntelyGentes.Controllers
{   
    [AllowAnonymous]
    public class LibreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
