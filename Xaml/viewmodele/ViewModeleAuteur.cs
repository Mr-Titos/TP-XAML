using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Xaml.viewmodele
{
    class ViewModeleAuteur
    {
        Modele.Donnees db = Modele.Donnees.GetInstance();

        public void NouvelleAuteur(string pseudo, int id)
        {
            db.auteur.Add(new Modele.auteur()
            {
                pseudo_auteur = pseudo,
                id_auteur = id,
            }
            );
            db.SaveChanges();
            MessageBox.Show("L'auteur " + pseudo + " a bien été enregistrée!");
        }

        public List<Modele.auteur> getLesAuteur()
        {
            return db.auteur.ToList();
        }

        public Modele.auteur getLauteur(int x)
        {
            var aut = from auteur in db.auteur where auteur.id_auteur == x select auteur;
            return aut.ToList()[0];
        }

        public void ModifierAuteur(int x, String pseudo)
        {
            Modele.auteur aut = getLauteur(x);
            aut.pseudo_auteur = pseudo;
            db.SaveChanges();
            MessageBox.Show("L'auteur n°" + x + " a bien été modifié!");
        }

        public void AjouterAuteur(string pseudo, string mdp, string img, string nom
            , string pre, string rue, string cp, string ville, string tel, string email, string desc)
        {
            db.auteur.Add(new Modele.auteur()
            {
                pseudo_auteur = pseudo,
                mdp_auteur = mdp,
                img_auteur = img,
                nom_auteur = nom == null ? "" : nom,
                pre_auteur = pre == null ? "" : pre,
                rue_auteur = rue == null ? "" : rue,
                cp_auteur = cp == null ? "" : cp,
                ville_auteur = ville == null ? "" : ville,
                tel_auteur = tel == null ? "" : tel,
                email_auteur = email == null ? "" : email,
                descriptif = desc == null ? "" : desc,
            }
            );
            db.SaveChanges();
            MessageBox.Show("L'auteur " + pseudo + " a bien été ajouté!");
        }
        public void SupprimerAuteur(int id)
        {
            Modele.auteur auteurToRemove = getLauteur(id);
            db.auteur.Remove(auteurToRemove);
            db.SaveChanges();
            MessageBox.Show("L'auteur " + auteurToRemove.pseudo_auteur + " a bien été supprimé!");
        }
    }
}