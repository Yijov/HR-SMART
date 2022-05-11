using CORE.Departamentos;
using CORE.Empleados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }


        //filter softdeleted items out of queryes
           protected override void OnModelCreating(ModelBuilder modelBuilder)
           {
               modelBuilder.Entity<Departamento>().HasQueryFilter(p => !p.SoftDeleted);
               modelBuilder.Entity<Empleado>().HasQueryFilter(p => !p.SoftDeleted);
           }
    }
}
