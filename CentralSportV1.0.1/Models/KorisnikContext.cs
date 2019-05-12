namespace CentralSportV1._0._1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KorisnikContext : DbContext
    {
        public KorisnikContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<korisnik> korisnik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<korisnik>()
                .Property(e => e.imeKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.prezimeKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.lokacijaKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.interesiKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.kratkiOpisKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.registracijskiEmailKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.kontaktEmailKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.kontaktTelefonKorisnik)
                .IsUnicode(false);

            modelBuilder.Entity<korisnik>()
                .Property(e => e.lozinkaKorisnik)
                .IsUnicode(false);
        }
    }
}
