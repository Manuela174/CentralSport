namespace CentralSportV1._0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[centralsportv1.0.1].korisnik")]
    public partial class korisnik
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idKorisnik { get; set; }

        [StringLength(45)]
        public string imeKorisnik { get; set; }

        [StringLength(45)]
        public string prezimeKorisnik { get; set; }

        [StringLength(100)]
        public string lokacijaKorisnik { get; set; }

        [StringLength(300)]
        public string interesiKorisnik { get; set; }

        [StringLength(500)]
        public string kratkiOpisKorisnik { get; set; }

        [Display(Name = " E-mail ")]
        [EmailAddress(ErrorMessage ="E-mail adresa nije valjana!")]
        [StringLength(45)]
        [DataType(DataType.EmailAddress)]
        public string registracijskiEmailKorisnik { get; set; }

        [StringLength(45)]
        public string kontaktEmailKorisnik { get; set; }

        [StringLength(45)]
        public string kontaktTelefonKorisnik { get; set; }

        [Display(Name = " Lozinka ")]
        [Required (ErrorMessage = "Lozinka je obavezna!")]
        [StringLength(45, MinimumLength =6)]
        [DataType(DataType.Password)]
        public string lozinkaKorisnik { get; set; }
    }
}
