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

namespace Q2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //here we set a person so be graeme and 19, but so this is two way, it can be changed when the program is running.
        //LOOK TO THE XML TO SEE HOW TWO WAY IS BEING ACHIEVED
        Student student = new Student { Firstname = "John", Lastname = "Smith", Age = 43 };


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = student;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //attatching a message from the student class to send to an alertbox once the button is clicked.
            string message = student.Firstname + student.Lastname + " is " + student.Age;
            MessageBox.Show(message);
        }
    }
}
