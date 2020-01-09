using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOn2_3
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

        private void italian_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Boungiorno";
        }

        private void Spanish_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void German_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Gueten Morgen";
        }
    }
}
