using FlowerShop.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace FlowerShop.UI
{
    /// <summary>
    /// Логика взаимодействия для Page_Authorization.xaml
    /// </summary>
    public partial class Page_Authorization : Page
    {
        public Page_Authorization()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxShowPassword.IsChecked.Value)
            {
                tbPassword.Text = pbPassword.Password;
                pbPassword.Visibility = Visibility.Hidden;
                tbPassword.Visibility = Visibility.Visible;
            }
            else
            {
                pbPassword.Password = tbPassword.Text;
                pbPassword.Visibility = Visibility.Visible;
                tbPassword.Visibility = Visibility.Hidden;
            }
        }

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            Authorization.AccsessCheck(tbLogin.Text,tbPassword.Text,pbPassword.Password);
        }

        private void buttonViewProduct_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_ProductList());
        }
    }
}
