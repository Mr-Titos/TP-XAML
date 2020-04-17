using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Xaml.viewmodele
{
    class ViewModeleCommande
    {
        Modele.Donnees db = Modele.Donnees.GetInstance();
        //Insertion d'une nouvelle commande       
        public void NouvelleCommande(int idC, int idA)
        {
            db.commande.Add(new Modele.commande()
            {
                id_commande = idC,
                id_auteur = idA
            }
            );
            db.SaveChanges();
            MessageBox.Show("La commande " + idC + " a bien été enregistrée!");
        }
        //Récupérér la liste de commande      
        public List<Modele.commande> getLesCommandes()
        {
            return db.commande.ToList();
        }
        //Récupérér une commande       
        public Modele.commande getLaCommande(int x)
        {
            var comm = from lacommande in db.commande where lacommande.id_commande == x select lacommande;
            return comm.ToList()[0];
        }
        //Récupérér une auteur à partir d'une commande        
        public Modele.auteur getCommande(int x)
        {
            var autc = from lauteur in db.auteur where lauteur.id_auteur == x select lauteur;
            return autc.ToList()[0];

        }
        //Modifier une commande        
        public void ModifierCommande(int id, int idAuteur, DateTime date, double tot)
        {
            Modele.commande comm = getLaCommande(id);
            comm.dated_commande = date;
            comm.id_auteur = idAuteur;
            comm.tot_commande = tot;
            db.SaveChanges();
            MessageBox.Show("La commande n°" + id + " a bien été modifiée!");
        }
        //Ajouter une commande        
        public void AjouterCommande(int x, DateTime date, double tot)
        {
            db.commande.Add(new Modele.commande()
            {
                id_auteur = x,
                dated_commande = date,
                tot_commande = tot,
            }
            );
            db.SaveChanges();
            MessageBox.Show("La commande a bien été ajoutée!");
        }
        public void SupprimerCommande(int id)
        {
            Modele.commande commandeRemove = getLaCommande(id);
            db.commande.Remove(commandeRemove);
            db.SaveChanges();
            MessageBox.Show("La commande " + commandeRemove.id_commande + " a bien été supprimée!");
        }
    }
}