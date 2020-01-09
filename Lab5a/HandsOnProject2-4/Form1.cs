using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOnProject2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void finland_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland";
        }

        private void france_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France";
        }

        private void germany_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany";
        }

        private void countryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
