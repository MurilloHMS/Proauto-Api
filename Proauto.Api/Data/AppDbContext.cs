using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api_Proauto.Models;
using FlexiTools.Model;

namespace Proauto_Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicles> Vehicles { get; set; } = default!;
        public DbSet<Employees> Employees { get; set; } = default!;
    }
}
