using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiTry5.Data;
using ProiectMediiTry5.Models;

namespace ProiectMediiTry5.Pages.Jobs
{
    public class DeleteModel : PageModel
    {
        private readonly ProiectMediiTry5.Data.ProiectMediiTry5Context _context;

        public DeleteModel(ProiectMediiTry5.Data.ProiectMediiTry5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Job Job { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job.FirstOrDefaultAsync(m => m.ID == id);

            if (job == null)
            {
                return NotFound();
            }
            else
            {
                Job = job;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job.FindAsync(id);
            if (job != null)
            {
                Job = job;
                _context.Job.Remove(Job);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
