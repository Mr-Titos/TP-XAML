namespace Xaml.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blague.categorie")]
    public partial class categorie
    {
        [Key]
        public int id_categorie { get; set; }

        [Required]
        [StringLength(100)]
        public string lib_categorie { get; set; }

        public int id_illustration { get; set; }
    }
}
