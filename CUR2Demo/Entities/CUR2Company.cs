using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;
using CUR2Demo.Models.Day2;

namespace CUR2Demo.Entities
{
    public class CUR2Company : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer("Server =.;Database=CUR2CompanyMVC;Trust Connection= True ; Encrypt = False");
            optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = CUR2CompanyMVC; Integrated Security = True; Encrypt = False;");
           

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department > Departments { get; set; }
    }
}
