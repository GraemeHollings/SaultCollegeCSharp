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


namespace Q4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ProductDBEntities dataEntities = new ProductDBEntities();



        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, SelectionChangedEventArgs e)
        {
            
            //the grid would not pull this data.
            var query =
            from c
            in dataEntities.products
            select new {c.ProductID, c.UnitPrice, c.ProductName};

            dataGrid1.ItemsSource = query.ToList();

           


        }
    }
}
