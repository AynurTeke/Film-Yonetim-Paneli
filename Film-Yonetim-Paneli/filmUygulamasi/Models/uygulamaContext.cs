using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmUygulamasi.Models
{
    public class uygulamaContext : DbContext
    {
        public uygulamaContext(DbContextOptions<uygulamaContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NQJARKP;Initial Catalog=filmUygulamasi;Integrated Security=True");
        }
        public DbSet<film> films { get; set; }
        public DbSet<salon> salons { get; set; }
        public DbSet<filmSalon> filmSalons { get; set; }
    }
}
