using System.Windows;
using Xaml.view;


namespace Xaml.viewmodele
{
    class ViewModeleAccueil
    {
        public Administrateur admin = new Administrateur();
        public void OuvrirPageMenu(Window a)
        {
            MenuPage menu = new MenuPage();
            a.Content = menu;
            a.Show();
        }
        public void FermerPageMenu(Window a)
        {
            MenuPage login = new MenuPage();
            a.Content = login;
            a.Show();
        }
    }

}
