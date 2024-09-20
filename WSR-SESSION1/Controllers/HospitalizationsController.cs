using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSR_SESSION1.Models;

namespace WSR_SESSION1.Controllers
{
    public class HospitalizationsController(WSRDbContext context) : Controller
    {
        private readonly WSRDbContext _context = context;

        // GET: Hospitalizations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hospitalization.ToListAsync());
        }

        // GET: Hospitalizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitalization = await _context.Hospitalization
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospitalization == null)
            {
                return NotFound();
            }

            return View(hospitalization);
        }

        // GET: Hospitalizations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hospitalizations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PatientId,Code,Date,Department,Conditions,AdditionalInfo,IsCancelled,CancellationReason")] Hospitalization hospitalization)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospitalization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }
            return View(hospitalization);
        }
        private bool HospitalizationExists(int id)
        {
            return _context.Hospitalization.Any(e => e.Id == id);
        }
    }
}
