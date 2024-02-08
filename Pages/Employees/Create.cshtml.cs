using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectMediiTry5.Data;
using ProiectMediiTry5.Models;

namespace ProiectMediiTry5.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly ProiectMediiTry5.Data.ProiectMediiTry5Context _context;

        public CreateModel(ProiectMediiTry5.Data.ProiectMediiTry5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ProjectID"] = new SelectList(_context.Set<Project>(), "ID",
"ProjectName");
            ViewData["DepartmentID"] = new SelectList(_context.Set<Department>(), "ID",
"Name");
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
