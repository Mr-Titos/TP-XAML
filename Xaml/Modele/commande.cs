namespace Xaml.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blague.commande")]
    public partial class commande
    {
        [Key]
        public int id_commande { get; set; }

        public int id_auteur { get; set; }

        [Column(TypeName = "date")]
        public DateTime dated_commande { get; set; }

        public double? tot_commande { get; set; }

        public virtual auteur auteur { get; set; }
    }
}
