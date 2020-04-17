namespace Xaml.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blague.utilisationcoupon")]
    public partial class utilisationcoupon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_auteur { get; set; }

        public int etat { get; set; }

        public virtual auteur auteur { get; set; }

        public virtual coupons coupons { get; set; }
    }
}
