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
    /// Interaction logic for PageLoved.xaml
    /// </summary>
    public partial class PageLoved : Page
    {
        public PageLoved()
        {
            InitializeComponent();
        }

        private void BtnClick8(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }

        private void BtnClick10(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void BtnClickDsk(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("DeskripsiPage.xaml", UriKind.Relative));
        }

        private void BtnClickFood(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("PageLovedFood.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("DeskripsiPage.xaml", UriKind.Relative));
        }
    }
}
