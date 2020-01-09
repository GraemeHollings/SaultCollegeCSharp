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

namespace Lab8B
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

            Lab8B.ProductDBDataSet productDBDataSet = ((Lab8B.ProductDBDataSet)(this.FindResource("productDBDataSet")));
            // Load data into the table products. You can modify this code as needed.
            Lab8B.ProductDBDataSetTableAdapters.productsTableAdapter productDBDataSetproductsTableAdapter = new Lab8B.ProductDBDataSetTableAdapters.productsTableAdapter();
            productDBDataSetproductsTableAdapter.Fill(productDBDataSet.products);
            System.Windows.Data.CollectionViewSource productsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productsViewSource")));
            productsViewSource.View.MoveCurrentToFirst();
        }
    }
}
