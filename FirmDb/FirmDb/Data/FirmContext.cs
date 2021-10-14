using FirmDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirmDb
{
    public class FirmContext : DbContext
    {
        public FirmContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; integrated Security=true; Database=FirmDb");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
