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
    public class IndexModel : PageModel
    {
        private readonly ProiectMediiTry5.Data.ProiectMediiTry5Context _context;

        public IndexModel(ProiectMediiTry5.Data.ProiectMediiTry5Context context)
        {
            _context = context;
        }

        public IList<Job> Job { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Job = await _context.Job.Include(b => b.Project).ToListAsync();
        }
    }
}
