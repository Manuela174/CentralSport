namespace CentralSportV1._0._1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PoduzećeContext : DbContext
    {
        public PoduzećeContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<poduzeće> poduzeće { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<poduzeće>()
                .Property(e => e.imePoduzeće)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.lokacijaPoduzeće)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.opisPoduzeće)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.dostupniTermini)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.dostupniTreneri)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.cijenaUsluga)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.kontaktTelefon)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.kontaktEmail)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.lozinkaPoduzeće)
                .IsUnicode(false);

            modelBuilder.Entity<poduzeće>()
                .Property(e => e.djelatnostiPoduzeće)
                .IsUnicode(false);
        }
    }
}
