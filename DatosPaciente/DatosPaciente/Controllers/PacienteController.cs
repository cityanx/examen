using DatosPaciente.Data;
using DatosPaciente.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatosPaciente.Controllers
{
    public class PacienteController : Controller
    {

        private readonly ApplicationDbContext db;

        public PacienteController(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<IActionResult> Index()
        {
            return View(await db.Pacientes.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacient = await db.Pacientes.FirstOrDefaultAsync(b => b.PacienteID == id);
            if (pacient == null)
            {
                return NotFound();
            }

            return View(pacient);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Paciente pacient)
        {
            if (ModelState.IsValid)
            {
                db.Add(pacient);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pacient);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacient = await db.Pacientes.FindAsync(id);

            if (pacient == null)
            {
                return NotFound();
            }

            return View(pacient);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Paciente pacient)
        {
            if (id != pacient.PacienteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(pacient);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(pacient);

        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacient = await db.Pacientes.FirstOrDefaultAsync(b => b.PacienteID == id);
            if (pacient == null)
            {
                return NotFound();
            }

            return View(pacient);
        }




        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var pacient = await db.Pacientes.FindAsync(id);
            db.Pacientes.Remove(pacient);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
