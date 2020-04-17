namespace Xaml.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blague.coupons")]
    public partial class coupons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public coupons()
        {
            utilisationcoupon = new HashSet<utilisationcoupon>();
        }

        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [Required]
        [StringLength(3)]
        public string reductions { get; set; }

        [Column(TypeName = "date")]
        public DateTime periodevalidite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<utilisationcoupon> utilisationcoupon { get; set; }
    }
}
