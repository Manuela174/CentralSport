namespace CentralSportV1._0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[centralsportv1.0.1].korisničkarecenzija")]
    public partial class korisničkarecenzija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idKorisničkaRecenzija { get; set; }

        [StringLength(5000)]
        public string opisKorisničkaRecenzija { get; set; }

        public float? ocjenaKorisničkaRecenzija { get; set; }
    }
}
