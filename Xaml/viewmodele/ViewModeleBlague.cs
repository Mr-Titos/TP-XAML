using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Xaml.viewmodele
{
    class ViewModeleBlague
    {
        Modele.Donnees db = Modele.Donnees.GetInstance();

        public void NouvelleCategorie(int id, string titre)
        {
            db.blagues.Add(new Modele.blagues()
            {
                id_blague = id,
                titre_blague = titre,
            }
            );
            db.SaveChanges();
            MessageBox.Show("La blague " + id + " a bien été enregistrée!");
        }

        public List<Modele.blagues> getLesBlagues()
        {
            return db.blagues.ToList();
        }

        public Modele.blagues getLaBlague(int x)
        {
            var blague = from lablague in db.blagues where lablague.id_blague == x select lablague;
            return blague.ToList()[0];
        }

        public void ModifierBlague(int x, String titre)
        {
            Modele.blagues blague = getLaBlague(x);
            blague.titre_blague = titre;
            db.SaveChanges();
            MessageBox.Show("La blague n°" + x + " a bien été modifiée!");
        }

        public void AjouterBlague(int cat, string titre, string desc, int ill, int aut, double px)
        {
            db.blagues.Add(new Modele.blagues()
            {
                id_categorie = cat,
                titre_blague = titre,
                desc_blague = desc,
                id_illustration = ill,
                id_auteur = aut,
                px_blague = px
            }
            );
            db.SaveChanges();
            MessageBox.Show("La blague " + titre + " a bien été ajoutée!");
        }
        public void SupprimerBlague(int id)
        {
            Modele.blagues blagueToRemove = getLaBlague(id);
            db.blagues.Remove(blagueToRemove);
            db.SaveChanges();
            MessageBox.Show("La blague " + blagueToRemove.id_blague + " a bien été supprimée!");
        }
    }
}