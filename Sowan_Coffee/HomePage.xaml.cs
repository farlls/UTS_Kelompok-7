﻿using System;
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
using System.Data.SqlClient;

namespace Sowan_Coffee
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>z
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLovedFood.xaml", UriKind.Relative));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLovedFood.xaml", UriKind.Relative));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLovedFood.xaml", UriKind.Relative));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.NavigationHomePage.Navigate(new Uri("PageLovedFood.xaml", UriKind.Relative));
        }
    }
}
