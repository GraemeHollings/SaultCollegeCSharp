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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //here we set a person so be graeme and 19, but so this is two way, it can be changed when the program is running.
        //LOOK TO THE XML TO SEE HOW TWO WAY IS BEING ACHIEVED
        Person person = new Person { Name = "Graeme", Age = 19 };


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void OkayButton_Click(object sender, RoutedEventArgs e)
        {
            //outputting the person object to the textbox
            string message = person.Name + "is " + person.Age;
            MessageBox.Show(message);
        }
    }
}
