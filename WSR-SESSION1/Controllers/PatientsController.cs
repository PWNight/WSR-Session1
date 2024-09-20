using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSR_SESSION1.Models;

namespace WSR_SESSION1.Controllers
{
    public class PatientsController(WSRDbContext context) : Controller
    {
        private readonly WSRDbContext _context = context;

        // GET: Patients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Patients.ToListAsync());
        }

        // GET: Patients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fio,PassportData,WorkPlace,PolicyNumber,PolicyExpire,PolicyCompany,MedicalCardId,PhotoPath")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }
        private bool PatientExists(int id)
        {
            return _context.Patients.Any(e => e.Id == id);
        }
    }
}