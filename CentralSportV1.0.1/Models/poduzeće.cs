namespace CentralSportV1._0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[centralsportv1.0.1].poduzeće")]
    public partial class poduzeće
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPoduzeće { get; set; }

        [StringLength(45)]
        public string imePoduzeće { get; set; }

        [StringLength(100)]
        public string lokacijaPoduzeće { get; set; }

        [StringLength(5000)]
        public string opisPoduzeće { get; set; }

        [StringLength(500)]
        public string dostupniTermini { get; set; }

        [StringLength(500)]
        public string dostupniTreneri { get; set; }

        [StringLength(500)]
        public string cijenaUsluga { get; set; }

        [StringLength(200)]
        public string kontaktTelefon { get; set; }

        [StringLength(200)]
        public string kontaktEmail { get; set; }

        [StringLength(45)]
        public string lozinkaPoduzeće { get; set; }

        [StringLength(500)]
        public string djelatnostiPoduzeće { get; set; }
    }
}
