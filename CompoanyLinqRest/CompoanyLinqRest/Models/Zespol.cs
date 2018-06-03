namespace CompoanyLinqRest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zespoly")]
    public partial class Zespol
    {
        [Key]
        public int IdZesp { get; set; }

        [StringLength(20)]
        public string Nazwa { get; set; }

        [StringLength(20)]
        public string Adres { get; set; }
    }
}
