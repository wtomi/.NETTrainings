namespace CompoanyLinqRest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pracownicy")]
    public partial class Pracownik
    {
        [Key]
        public int IdPrac { get; set; }

        [StringLength(15)]
        public string Nazwisko { get; set; }

        [StringLength(10)]
        public string Etat { get; set; }

        public int? IdSzefa { get; set; }

        public DateTime? Zatrudniony { get; set; }

        public decimal? PlacaPod { get; set; }

        public decimal? PlacaDod { get; set; }

        public int? IdZesp { get; set; }
    }
}
