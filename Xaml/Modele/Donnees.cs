namespace Xaml.Modele
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Donnees : DbContext
    {
        private static Donnees getInstance;
        private Donnees() 
            : base("name=Donnees") /*Adapter au code [1]*/        { }
        public static Donnees GetInstance()
        {
            if (getInstance == null)
            {
                getInstance = new Donnees();
            }
            return getInstance;
        }


        public virtual DbSet<auteur> auteur { get; set; }
        public virtual DbSet<blagues> blagues { get; set; }
        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<commande> commande { get; set; }
        public virtual DbSet<coupons> coupons { get; set; }
        public virtual DbSet<illustration> illustration { get; set; }
        public virtual DbSet<lcommande> lcommande { get; set; }
        public virtual DbSet<utilisationcoupon> utilisationcoupon { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<auteur>()
                .Property(e => e.pseudo_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.mdp_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.img_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.nom_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.pre_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.rue_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.cp_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.ville_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.tel_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.email_auteur)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .Property(e => e.descriptif)
                .IsUnicode(false);

            modelBuilder.Entity<auteur>()
                .HasMany(e => e.commande)
                .WithRequired(e => e.auteur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auteur>()
                .HasMany(e => e.utilisationcoupon)
                .WithRequired(e => e.auteur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<blagues>()
                .Property(e => e.titre_blague)
                .IsUnicode(false);

            modelBuilder.Entity<blagues>()
                .Property(e => e.desc_blague)
                .IsUnicode(false);

            modelBuilder.Entity<categorie>()
                .Property(e => e.lib_categorie)
                .IsUnicode(false);

            modelBuilder.Entity<coupons>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<coupons>()
                .Property(e => e.reductions)
                .IsUnicode(false);

            modelBuilder.Entity<coupons>()
                .HasMany(e => e.utilisationcoupon)
                .WithRequired(e => e.coupons)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<illustration>()
                .Property(e => e.img_illustration)
                .IsUnicode(false);

            modelBuilder.Entity<utilisationcoupon>()
                .Property(e => e.code)
                .IsUnicode(false);
        }
    }
}
