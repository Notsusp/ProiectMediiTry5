using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectMediiTry5.Models;

namespace ProiectMediiTry5.Data
{
    public class ProiectMediiTry5Context : DbContext
    {
        public ProiectMediiTry5Context (DbContextOptions<ProiectMediiTry5Context> options)
            : base(options)
        {
        }

        public DbSet<ProiectMediiTry5.Models.Project> Project { get; set; } = default!;
        public DbSet<ProiectMediiTry5.Models.Job> Job { get; set; } = default!;
        public DbSet<ProiectMediiTry5.Models.Employee> Employee { get; set; } = default!;
        public DbSet<ProiectMediiTry5.Models.Department> Department { get; set; } = default!;
    }
}
