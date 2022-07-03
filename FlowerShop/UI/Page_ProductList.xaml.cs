using FlowerShop.Database;
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

namespace FlowerShop.UI
{
    /// <summary>
    /// Логика взаимодействия для Page_ProductList.xaml
    /// </summary>
    public partial class Page_ProductList : Page
    {
        public Page_ProductList()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            productList.ItemsSource = FS.GetContext().Product.ToList();
        }
    }
}
