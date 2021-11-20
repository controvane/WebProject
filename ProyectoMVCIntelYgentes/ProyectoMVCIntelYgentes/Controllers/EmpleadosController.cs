using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoMVCIntelYgentes.Models.Datos;

namespace ProyectoMVCIntelYgentes.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly rrhhContext _context;

        public EmpleadosController(rrhhContext context)
        {
            _context = context;
        }

        // GET: Empleados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empleado.ToListAsync());
        }

        // GET: Empleados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado
                .FirstOrDefaultAsync(m => m.EmpNo == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: Empleados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpNo,FechaNacimiento,Nombre,Paterno,Materno,Genero,FechaContrato")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }

        // POST: Empleados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpNo,FechaNacimiento,Nombre,Paterno,Materno,Genero,FechaContrato")] Empleado empleado)
        {
            if (id != empleado.EmpNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpleadoExists(empleado.EmpNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Firing(int id, [Bind("EmpNo,FechaNacimiento,Nombre,Paterno,Materno,Genero,FechaContrato")] Empleado empleado)
        {
            if (id != empleado.EmpNo)
            {
                Console.WriteLine("No encontre el registro");
                return NotFound();
            }
            //Seccion para actualizar las otras tablas para el despido
            rrhhContext db = new rrhhContext();
            try
            {
                Empleado newEmpleado = db.Empleado.SingleOrDefault(b => b.EmpNo == empleado.EmpNo);
                newEmpleado.FechaContrato = null;
                DeptoEmp deptoEmpToUpdate = db.DeptoEmp.SingleOrDefault(b => b.EmpleadoEmpNo == empleado.EmpNo);
                deptoEmpToUpdate.FechaFin = DateTime.Now;
                Sueldos sueldo = db.Sueldos.SingleOrDefault(b => b.EmpNo == empleado.EmpNo);
                sueldo.HastaFecha = DateTime.Now;
                Cargo cargo = db.Cargo.SingleOrDefault(b => b.EmpleadoEmpNo == empleado.EmpNo);
                cargo.FechaFin = DateTime.Now;
                if (db.DeptoJefe.SingleOrDefault(b => b.EmpleadoEmpNo == empleado.EmpNo) != null)
                {
                    DeptoJefe deptoJefe = db.DeptoJefe.SingleOrDefault(b => b.EmpleadoEmpNo == empleado.EmpNo);
                    deptoJefe.FechaFin = DateTime.Now;
                }
                db.SaveChanges();
            }
            catch (Exception)
            {
                Console.WriteLine("No pude escribir algo a la bd");
                return NotFound();
            }       
            return RedirectToAction(nameof(Index));
        }

        // GET: Empleados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado
                .FirstOrDefaultAsync(m => m.EmpNo == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleado = await _context.Empleado.FindAsync(id);
            _context.Empleado.Remove(empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleado.Any(e => e.EmpNo == id);
        }
    }
}
