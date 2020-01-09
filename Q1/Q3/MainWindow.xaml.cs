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
            //creating a new classList of type student
            List<Student> classList = new List<Student> {
            new Student("Graeme", "Hollingsworth", 19),
            new Student("Steve", "Logan", 75),
            new Student("Connor", "Doda", 25),
            new Student("Joey", "Maxwell", 21)
        };

            //not sure why i keep getting null ref here...
            //attempting to populate the combo box with the list here
            comboBox.DataContext = classList;
            


            InitializeComponent();
        }
    }
}
