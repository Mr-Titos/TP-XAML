using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Xaml.viewmodele
{
    class ViewModeleCategorie
    {
        Modele.Donnees db = Modele.Donnees.GetInstance();

        public void NouvelleCategorie(string libelle, int illustration)
        {
            db.categorie.Add(new Modele.categorie()
            {
                lib_categorie = libelle,
                id_illustration = illustration
            }
            );
            db.SaveChanges();
            MessageBox.Show("La catégorie " + libelle + " a bien été enregistrée!");
        }

        public List<Modele.categorie> getLesCategorie()
        {
            return db.categorie.ToList();
        }

        public Modele.categorie getLaCategorie(int x)
        {
            var cat = from lacategorie in db.categorie where lacategorie.id_categorie == x select lacategorie;
            return cat.ToList()[0];
        }

        public Modele.illustration getIllustration(int x)
        {
            var illus = from lillustration in db.illustration where lillustration.id_illustration == x select lillustration;
            return illus.ToList()[0];

        }

        public void ModifierCategorie(int x, String libelle)
        {
            Modele.categorie cat = getLaCategorie(x);
            cat.lib_categorie = libelle;
            db.SaveChanges();
            MessageBox.Show("La catégorie n°" + x + " a bien été modifiée!");
        }

        public void AjouterCategorie(String lib, int x)
        {
            db.categorie.Add(new Modele.categorie()
            {
                lib_categorie = lib,
                id_illustration = x
            }
            );
            db.SaveChanges();
            MessageBox.Show("La catégorie " + lib + " a bien été ajoutée!");
        }

        public void SupprimerCategorie(int id)
        {
            Modele.categorie categorieToRemove = getLaCategorie(id);
            db.categorie.Remove(categorieToRemove);
            db.SaveChanges();
            MessageBox.Show("La catégorie " + id + " a bien été supprimée!");
        }
    }
}