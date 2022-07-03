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

namespace FlowerShop.UC
{
    /// <summary>
    /// Логика взаимодействия для UserControl_ProductCard.xaml
    /// </summary>
    public partial class UserControl_ProductCard : UserControl
    {
        public UserControl_ProductCard()
        {
            InitializeComponent();
        }
        public UserControl_ProductCard(Product product)
        {
            InitializeComponent();
            DataContext = product;
        }
    }
}
