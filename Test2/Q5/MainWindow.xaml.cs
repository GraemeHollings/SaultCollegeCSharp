using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Q5
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
            


            Q5.Test2DBDataSet test2DBDataSet = ((Q5.Test2DBDataSet)(this.FindResource("test2DBDataSet")));
            // Load data into the table ThoughtsDB. You can modify this code as needed.
            Q5.Test2DBDataSetTableAdapters.ThoughtsDBTableAdapter test2DBDataSetThoughtsDBTableAdapter = new Q5.Test2DBDataSetTableAdapters.ThoughtsDBTableAdapter();
            test2DBDataSetThoughtsDBTableAdapter.Fill(test2DBDataSet.ThoughtsDB);
            System.Windows.Data.CollectionViewSource thoughtsDBViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("thoughtsDBViewSource")));
            thoughtsDBViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string DBConn = @"Data Source=.\sqlexpress;Initial Catalog=Test2DB;Integrated Security=True";
            SqlConnection con = new SqlConnection(DBConn);
           
            //this is where an error was thrown.
            SqlCommand cmd = new SqlCommand("INSERT", con);
            
            cmd.Parameters.AddWithValue("@password", Password.Text);
            cmd.Parameters.AddWithValue("@thoughts", Thoughts.Text);
            
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();



            //SqlCommand myCommand = new SqlCommand("INSERT INTO dbo.Table(Id, password, thoughts) VALUES(1, Password.Text, Thoughts.Text)");
        }
    }
}
