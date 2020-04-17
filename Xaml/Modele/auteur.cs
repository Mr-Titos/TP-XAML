namespace Xaml.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blague.auteur")]
    public partial class auteur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public auteur()
        {
            commande = new HashSet<commande>();
            utilisationcoupon = new HashSet<utilisationcoupon>();
        }

        [Key]
        public int id_auteur { get; set; }

        [Required]
        [StringLength(100)]
        public string pseudo_auteur { get; set; }

        [Required]
        [StringLength(50)]
        public string mdp_auteur { get; set; }

        [Required]
        [StringLength(100)]
        public string img_auteur { get; set; }

        [StringLength(100)]
        public string nom_auteur { get; set; }

        [StringLength(100)]
        public string pre_auteur { get; set; }

        [StringLength(200)]
        public string rue_auteur { get; set; }

        [StringLength(5)]
        public string cp_auteur { get; set; }

        [StringLength(255)]
        public string ville_auteur { get; set; }

        [StringLength(10)]
        public string tel_auteur { get; set; }

        [StringLength(100)]
        public string email_auteur { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string descriptif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commande { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<utilisationcoupon> utilisationcoupon { get; set; }
    }
}
