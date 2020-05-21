using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class KonekcijaNaBazu: DbContext
    {
        public KonekcijaNaBazu(): base("PutanjaDoBaze")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Spolovi> Spolovi { get; set; }
        public DbSet<Predmeti> Predmeti { get; set; }
        public DbSet<KorisniciPredmeti> KorisniciPredmeti{ get; set; }
    }
}
