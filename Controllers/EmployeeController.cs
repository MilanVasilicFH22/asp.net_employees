using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.ID == id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Prename,Lastname")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
    }
}
