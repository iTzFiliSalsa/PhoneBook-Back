using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using agenda.Models;

namespace agenda
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
    }
}
