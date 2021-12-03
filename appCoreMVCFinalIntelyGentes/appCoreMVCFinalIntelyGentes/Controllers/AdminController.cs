using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using appCoreMVCFinalIntelyGentes.ViewModels;


namespace appCoreMVCFinalIntelyGentes.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
       
        public AdminController(UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var usuarios = _userManager.Users;
            var roles = _roleManager.Roles;
            List<IdentityUser> lista1 = usuarios.ToList<IdentityUser>();
            List<IdentityRole> lista2 = roles.ToList<IdentityRole>();
            AdminIndex Vmodel1 = new AdminIndex();
            Vmodel1.lista1 = lista1;
            Vmodel1.lista2 = lista2;
            return View(Vmodel1);
        }
    }
}
