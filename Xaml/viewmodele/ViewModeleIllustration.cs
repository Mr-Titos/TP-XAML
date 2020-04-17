using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Xaml.viewmodele
{
    class ViewModeleIllustration
    {
        Modele.Donnees db = Modele.Donnees.GetInstance();

        public void NouvelleIllstration(string img, int id)
        {
            db.illustration.Add(new Modele.illustration()
            {
                img_illustration = img,
                id_illustration = id,
            }
            );
            db.SaveChanges();
            MessageBox.Show("L'illustration " + id + " bien été enregistrée!");
        }

        public List<Modele.illustration> getLesIllustrations()
        {
            return db.illustration.ToList();
        }

        public Modele.illustration getLillustration(int x)
        {
            var ill = from lillustration in db.illustration where lillustration.id_illustration == x select lillustration;
            return ill.ToList()[0];
        }


        public void ModifierIllustration(int x, string img)
        {
            Modele.illustration ill = getLillustration(x);
            ill.img_illustration = img;
            db.SaveChanges();
            MessageBox.Show("L'illustration n°" + x + " a bien été modifiée!");
        }

        public void AjouterIllustration(string img)
        {
            db.illustration.Add(new Modele.illustration()
            {
                img_illustration = img,
            }
            );
            db.SaveChanges();
            MessageBox.Show("L'illustration a bien été ajoutée!");
        }
        public void SupprimerIllustration(int id)
        {
            Modele.illustration illustrationToRemove = getLillustration(id);
            db.illustration.Remove(illustrationToRemove);
            db.SaveChanges();
            MessageBox.Show("L'illustration " + illustrationToRemove.id_illustration + " a bien été supprimée!");
        }
    }
}