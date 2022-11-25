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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnClick7(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }

        private void BtnClick9(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }
    }
}
