using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCars.Models
{
    public class EMPLContext :DbContext
    {
        public DbSet<Employee> Employes { get; set; }
        public EMPLContext(DbContextOptions<EMPLContext> options) : base(options)
        { Database.EnsureCreated(); }

    }
}
