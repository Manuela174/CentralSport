namespace CentralSportV1._0._1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KorisničkaRecenzijaContext : DbContext
    {
        public KorisničkaRecenzijaContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<korisničkarecenzija> korisničkarecenzija { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<korisničkarecenzija>()
                .Property(e => e.opisKorisničkaRecenzija)
                .IsUnicode(false);
        }
    }
}
