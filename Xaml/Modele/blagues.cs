namespace Xaml.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blague.blagues")]
    public partial class blagues
    {
        [Key]
        public int id_blague { get; set; }

        public int id_categorie { get; set; }

        [Required]
        [StringLength(100)]
        public string titre_blague { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string desc_blague { get; set; }

        public int id_illustration { get; set; }

        public int id_auteur { get; set; }

        public double? px_blague { get; set; }
    }
}
