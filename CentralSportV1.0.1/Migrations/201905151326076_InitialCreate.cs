namespace CentralSportV1._0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "[centralsportv1.0.1].korisnik",
                c => new
                    {
                        idKorisnik = c.Int(nullable: false),
                        imeKorisnik = c.String(maxLength: 45, unicode: false),
                        prezimeKorisnik = c.String(maxLength: 45, unicode: false),
                        lokacijaKorisnik = c.String(maxLength: 100, unicode: false),
                        interesiKorisnik = c.String(maxLength: 300, unicode: false),
                        kratkiOpisKorisnik = c.String(maxLength: 500, unicode: false),
                        registracijskiEmailKorisnik = c.String(maxLength: 45, unicode: false),
                        kontaktEmailKorisnik = c.String(maxLength: 45, unicode: false),
                        kontaktTelefonKorisnik = c.String(maxLength: 45, unicode: false),
                        lozinkaKorisnik = c.String(nullable: false, maxLength: 45, unicode: false),
                    })
                .PrimaryKey(t => t.idKorisnik);
            
        }
        
        public override void Down()
        {
            DropTable("[centralsportv1.0.1].korisnik");
        }
    }
}
