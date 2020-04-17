using System;
using System.Windows;
using System.Windows.Controls;
using Xaml.viewmodele;

namespace Xaml.view
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        ViewModeleCategorie lesCategories = new ViewModeleCategorie();
        ViewModeleAuteur lesAuteurs = new ViewModeleAuteur();
        ViewModeleBlague lesBlagues = new ViewModeleBlague();
        ViewModeleIllustration lesIllustrations = new ViewModeleIllustration();
        ViewModeleCommande lesCommandes = new ViewModeleCommande();



        public MenuPage()
        {
            InitializeComponent();
            dataGridCategorie.ItemsSource = lesCategories.getLesCategorie();
            dataGridAuteur.ItemsSource = lesAuteurs.getLesAuteur();
            dataGridBlagues.ItemsSource = lesBlagues.getLesBlagues();
            dataGridIllustration.ItemsSource = lesIllustrations.getLesIllustrations();
            dataGridCommande.ItemsSource = lesCommandes.getLesCommandes();
            txtNum.IsReadOnly = true;
            txtIdAuteur.IsReadOnly = true;
            txtBlagueNum.IsReadOnly = true;
            txtIllNum.IsReadOnly = true;
            txtCommNum.IsReadOnly = true;

        }
        // Boutons Categorie
        private void ValidCategorie(object sender, RoutedEventArgs e)
        {
            lesCategories.ModifierCategorie(Convert.ToInt16(txtNum.Text), TxtLibelle.Text);
        }

        private void AjouterCategorie(object sender, RoutedEventArgs e)
        {
            if (txtIllustration.Text.Length > 1 && TxtLibelle.Text.Length > 1)
            {
                lesCategories.AjouterCategorie(TxtLibelle.Text, Convert.ToInt16(txtIllustration.Text));
                dataGridCategorie.ItemsSource = lesCategories.getLesCategorie();
            }
            else
                MessageBox.Show("Veillez remplir au minimum les champs requis*");
        }

        private void SupprimerCategorie(object sender, RoutedEventArgs e)
        {
            lesCategories.SupprimerCategorie(Convert.ToInt16(txtNum.Text));
            dataGridCategorie.ItemsSource = lesCategories.getLesCategorie();
        }

        // Boutons Auteur
        private void ValidAuteur(object sender, RoutedEventArgs e)
        {
            lesAuteurs.ModifierAuteur(Convert.ToInt16(txtIdAuteur.Text), txtPseudoAuteur.Text);
        }

        private void Ajouterauteur(object sender, RoutedEventArgs e)
        {
            if (txtPseudoAuteur.Text.Length > 1 && txtMdpAuteur.Text.Length > 1 && txtImgAuteur.Text.Length > 1)
            {
                lesAuteurs.AjouterAuteur(txtPseudoAuteur.Text, txtMdpAuteur.Text, txtImgAuteur.Text, txtNomAuteur.Text, txtPreAuteur.Text, txtRueAuteur.Text, txtCpAuteur.Text, txtVilleAuteur.Text, txtTelAuteur.Text, txtEmailAuteur.Text, txtDescAuteur.Text);
                dataGridAuteur.ItemsSource = lesAuteurs.getLesAuteur();
            }
            else
                MessageBox.Show("Veillez remplir au minimum les champs requis*");
        }

        private void SupprimerAuteur(object sender, RoutedEventArgs e)
        {
            lesAuteurs.SupprimerAuteur(Convert.ToInt16(txtIdAuteur.Text));
            dataGridAuteur.ItemsSource = lesAuteurs.getLesAuteur();
        }

        // Boutons Blagues

        private void ValiderBlague(object sender, RoutedEventArgs e)
        {
            lesBlagues.ModifierBlague(Convert.ToInt16(txtBlagueNum.Text), TxtBlagueTitre.Text);
        }

        private void AjouterBlague(object sender, RoutedEventArgs e)
        {
            if (TxtBlagueCatNum.Text.Length >= 1 && TxtBlagueIll.Text.Length >= 1 && TxtBlagueIdAut.Text.Length >= 1 && TxtBlaguePrix.Text.Length >= 1)
            {
                lesBlagues.AjouterBlague(Convert.ToInt16(TxtBlagueCatNum.Text), TxtBlagueTitre.Text, TxtBlagueDesc.Text, Convert.ToInt16(TxtBlagueIll.Text), Convert.ToInt16(TxtBlagueIdAut.Text), Convert.ToDouble(TxtBlaguePrix.Text));
                dataGridBlagues.ItemsSource = lesBlagues.getLesBlagues();
            }
            else
                MessageBox.Show("Veillez remplir au minimum les champs requis*");
        }
        private void SupprimerBlague(object sender, RoutedEventArgs e)
        {
            lesBlagues.SupprimerBlague(Convert.ToInt16(txtBlagueNum.Text));
            dataGridBlagues.ItemsSource = lesBlagues.getLesBlagues();
        }

        // Boutons Illustrations
        private void ValiderIll(object sender, RoutedEventArgs e)
        {
            lesIllustrations.ModifierIllustration(Convert.ToInt16(txtIllNum.Text), TxtIllImg.Text);
        }

        private void AjouterIllustration(object sender, RoutedEventArgs e)
        {
            if (TxtIllImg.Text.Length >= 1)
            {
                lesIllustrations.AjouterIllustration(TxtIllImg.Text);
                dataGridIllustration.ItemsSource = lesIllustrations.getLesIllustrations();
            }
            else
                MessageBox.Show("Veillez remplir au minimum les champs requis*");
        }
        private void SupprimerIllustration(object sender, RoutedEventArgs e)
        {
            lesIllustrations.SupprimerIllustration(Convert.ToInt16(txtIllNum.Text));
            dataGridIllustration.ItemsSource = lesIllustrations.getLesIllustrations();
        }

        // Boutons commander
        private void ValiderCommande(object sender, RoutedEventArgs e)
        {
            DateTime? dateChecked = CheckDate(txtCommDate.Text);
            if (dateChecked.HasValue)
            {
                lesCommandes.ModifierCommande(Convert.ToInt16(txtCommNum.Text), Convert.ToInt16(TxtCommIdAut.Text), dateChecked.Value, Convert.ToDouble(txtCommTot.Text));
            }

        }

        private void AjouterCommande(object sender, RoutedEventArgs e)
        {
            DateTime? dateChecked = CheckDate(txtCommDate.Text);
            if (dateChecked.HasValue)
            {
                if (TxtCommIdAut.Text.Length >= 1 && txtCommDate.Text.Length >= 1)
                {
                    lesCommandes.AjouterCommande(Convert.ToInt16(TxtCommIdAut.Text), dateChecked.Value, Convert.ToDouble(txtCommTot.Text));
                    dataGridCommande.ItemsSource = lesCommandes.getLesCommandes();
                }
                else
                {
                    MessageBox.Show("Veillez remplir au minimum les champs requis*");
                }
            }
            else
            {
                MessageBox.Show("Vérifier le format de la date");
            }
        }

        private DateTime? CheckDate(string dateText)
        {
            string[] arrayDateTemp = dateText.Split(' ');
            string[] dateString = arrayDateTemp[0].Split('/');
            if (dateString[2].Length == 4 && dateString[1].Length <= 2 && dateString[0].Length <= 2)
            {
                return new DateTime(int.Parse(dateString[2]), int.Parse(dateString[0]), int.Parse(dateString[1]));
            }
            else
            {
                return null;
            }
        }

        private void SupprimerCommande(object sender, RoutedEventArgs e)
        {
            lesCommandes.SupprimerCommande(Convert.ToInt16(txtCommNum.Text));
            dataGridCommande.ItemsSource = lesCommandes.getLesCommandes();
        }

        private void txtCommDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*string MaChaine = txtCommDate.Text;
            string firstC = MaChaine.Substring(2,1);
            MessageBox.Show("valeur ", firstC);

            if (firstC != "/")
            {
                MessageBox.Show("valeur trouvé ", firstC);
                txtCommDate.Text = "0" + txtCommDate.Text;
                MessageBox.Show("correction", firstC);

            }
            txtCommDate.Text = MaChaine.Substring(0, 10);
        }
        */
        }
    }
}
