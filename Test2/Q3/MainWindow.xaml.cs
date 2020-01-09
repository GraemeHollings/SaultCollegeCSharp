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

namespace Q3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Q3.ProductDBDataSet productDBDataSet = ((Q3.ProductDBDataSet)(this.FindResource("productDBDataSet")));
            // Load data into the table products. You can modify this code as needed.
            Q3.ProductDBDataSetTableAdapters.productsTableAdapter productDBDataSetproductsTableAdapter = new Q3.ProductDBDataSetTableAdapters.productsTableAdapter();
            productDBDataSetproductsTableAdapter.Fill(productDBDataSet.products);
            System.Windows.Data.CollectionViewSource productsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productsViewSource")));
            productsViewSource.View.MoveCurrentToFirst();
        }
    }
}
