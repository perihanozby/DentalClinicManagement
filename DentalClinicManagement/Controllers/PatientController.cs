using Microsoft.AspNetCore.Mvc;
using DentalClinicManagement.Models;
using System.Linq;
using DentalClinicManagement.Data;

namespace DentalClinicManagement.Controllers
{
    public class PatientController: Controller
    {
        private readonly ApplicationDbContext _context;
        public PatientController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var patients= _context.Patients.ToList();
            return View(patients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Patients.Add(patient);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        public IActionResult Edit(int id) 
        {
            var patient = _context.Patients.Find(id);
            if(patient == null) return NotFound();
            return View(patient);
        }

        [HttpPost]
        public IActionResult Edit(Patient patient) 
        {
            if (ModelState.IsValid)
            {
                _context.Patients.Update(patient);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        public IActionResult Delete(int id) 
        {
            var patient = _context.Patients.Find(id);
            if(patient == null) return NotFound();
            return View(patient);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var patient = _context.Patients.Find(id);

            if (patient != null) 
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));

        }

    }
}
