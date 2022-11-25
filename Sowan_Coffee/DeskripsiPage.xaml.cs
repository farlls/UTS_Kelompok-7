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
    /// Interaction logic for DeskripsiPage.xaml
    /// </summary>
    public partial class DeskripsiPage : Page
    {
        public DeskripsiPage()
        {
            InitializeComponent();
        }

        private void BtnClickAtc(object sender, RoutedEventArgs e)
        {
            this.NavigationDeskripsiDrink.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            this.NavigationDeskripsiDrink.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }
    }
}
