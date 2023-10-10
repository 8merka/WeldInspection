using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_DAL_Admin.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Defects> Defects { get; set; }
        public DbSet<Inspectors> Inspectors { get; set; }
        public DbSet<FinalInspection> FinalInspections { get; set; }
        public DbSet<InspectionEquipment> InspectionEquipment { get; set; }
        public DbSet<InspectionMethods> InspectionMethods { get; set; }
        public DbSet<InspectionResult> InspectionResult { get; set; }
        public DbSet<Welds> Welds { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=WeldInspection;Username=postgres;Password=9100");
        }
    }
}
