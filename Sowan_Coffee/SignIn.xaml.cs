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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sowan_Coffee
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnClick3(object sender, RoutedEventArgs e)
        {
            this.NavigationSignIn.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void BtnClick4(object sender, RoutedEventArgs e)
        {
            this.NavigationSignIn.Navigate(new Uri("SignUp.xaml", UriKind.Relative));
        }
    }
}
