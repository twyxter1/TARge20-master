using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        // DEFAULT PROJECT: TARge20 DATA KÄSKLUS: Add-Migration NIMI Update-Database
        public DbSet<Ametinimetused> Ametinimetused { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Haiguslehe_tyyp> Haiguslehe_tyyp { get; set; }
        public DbSet<Haiguslehed> Haiguslehed { get; set; }
        public DbSet<Harukontor> Harukontor { get; set; }
        public DbSet<Laenutatav_ese> Laenutatav_ese { get; set; }
        public DbSet<Laenutuskord> Laenutuskord { get; set; }
        public DbSet<Ligipaasuloa_tyyp> Ligipaasuloa_tyyp { get; set; }
        public DbSet<Ligipaasuluba> Ligipaasuluba { get; set; }
        public DbSet<Palved> Palved { get; set; }
        public DbSet<Puhkuse_tyyp> Puhkuse_tyyp { get; set; }
        public DbSet<Puhkused> Puhkused { get; set; }
        public DbSet<T66suhe> T66suhe { get; set; }
        public DbSet<Tervisekontrollid> Tervisekontrollid { get; set; }
        public DbSet<Tootaja_laps> Tootaja_laps { get; set; }
        public DbSet<Vihjed> Vihjed { get; set; }

    }
}
