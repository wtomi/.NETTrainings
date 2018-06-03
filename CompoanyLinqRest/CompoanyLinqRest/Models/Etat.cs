namespace CompoanyLinqRest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Etaty")]
    public partial class Etat
    {
        [Key]
        [StringLength(10)]
        public string Nazwa { get; set; }

        public decimal? PlacaMin { get; set; }

        public decimal? PlacaMax { get; set; }
    }
}

