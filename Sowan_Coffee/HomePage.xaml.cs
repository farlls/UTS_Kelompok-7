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
using System.Data.SqlClient;

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
            using (SqlConnection connection = new SqlConnection(@"Data Source=FARLLS\SQLEXPRESS;Initial Catalog=sowan_coffee;Integrated Security=True"))
            {
                connection.Open();
                string sql = "SELECT Nama FROM [dbo].[User] WHERE Nama=@Nama";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {  
                    string textBlockUser = (string)command.ExecuteScalar();
                    txtusername.Text = textBlockUser;
                }
            }
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

        }
    }
}
