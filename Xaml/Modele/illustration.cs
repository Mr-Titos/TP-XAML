namespace Xaml.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blague.illustration")]
    public partial class illustration
    {
        [Key]
        public int id_illustration { get; set; }

        [Required]
        [StringLength(200)]
        public string img_illustration { get; set; }
    }
}
