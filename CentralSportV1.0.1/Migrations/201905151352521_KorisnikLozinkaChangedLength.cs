namespace CentralSportV1._0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KorisnikLozinkaChangedLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("[centralsportv1.0.1].korisnik", "lozinkaKorisnik", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("[centralsportv1.0.1].korisnik", "lozinkaKorisnik", c => c.String(nullable: false, maxLength: 45, unicode: false));
        }
    }
}
