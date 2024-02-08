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

namespace ProiectMediiTry5.Pages.Jobs
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
            return Page();
        }

        [BindProperty]
        public Job Job { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Job.Add(Job);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
