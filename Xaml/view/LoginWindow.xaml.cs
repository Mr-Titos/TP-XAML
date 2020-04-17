using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Xaml.viewmodele;

namespace Xaml.view
{
    public partial class LoginWindow : Window
    {
        ViewModeleAccueil controllerAccueil = new ViewModeleAccueil();
        public LoginWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == controllerAccueil.admin.login && txtmdp.Text == controllerAccueil.admin.mdp)
            {
                txtLogin.Text = "ok";
                controllerAccueil.OuvrirPageMenu(this);
                this.WindowState = WindowState.Maximized;
            }
        }
    }
}
