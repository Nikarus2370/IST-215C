using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_Buttons_with_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblOut_Click(object sender, EventArgs e)
        {

        }

        private void btnNH_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOut.Text = "Welcome to " + btn.Text;
        }

        private void btnMass_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOut.Text = "Welcome to " + btn.Text;
        }

        private void btnVT_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOut.Text = "Welcome to " + btn.Text;
        }

        private void btnLD_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOut.Text = "Welcome to " + btn.Text;
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOut.Text = "Welcome to " + btn.Text;
        }

        private void btnWA_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOut.Text = "Welcome to " + btn.Text;
        }
    }
}
