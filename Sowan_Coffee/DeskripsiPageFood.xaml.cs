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
    /// Interaction logic for DeskripsiPageFood.xaml
    /// </summary>
    public partial class DeskripsiPageFood : Page
    {
        public DeskripsiPageFood()
        {
            InitializeComponent();
        }

        private void BtnClikAtc(object sender, RoutedEventArgs e)
        {
            
        this.NavigationDeskripsiFood.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            this.NavigationDeskripsiFood.Navigate(new Uri("PageLovedFood.xaml", UriKind.Relative));
        }
    }
}
