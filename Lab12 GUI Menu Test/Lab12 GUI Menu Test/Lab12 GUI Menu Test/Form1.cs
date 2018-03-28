using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab12_GUI_Menu_Test
{
    public partial class frmMain : Form
    {
        string textFont = "Trebuchet MS";
        FontStyle Style1;
        FontStyle Style2;
        public frmMain()
        {
            InitializeComponent();
            DateTime todaysDate = DateTime.Today;
            toolStripStatusLabel1.Text = todaysDate.ToShortDateString() + " " + todaysDate.ToShortTimeString();
            textBox1.Text = todaysDate.ToShortDateString() + " " + todaysDate.ToShortTimeString();
            toolStripStatusLabel2.Text = todaysDate.ToShortDateString() + " " + todaysDate.ToShortTimeString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a small application made to showcase menus","About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void color_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            string color = i.Text;
            switch (color)
            {
                case "Black":
                    toolStripStatusLabel2.ForeColor = Color.Black;
                    blackToolStripMenuItem.Checked = true;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    break;
                case "Blue":
                    toolStripStatusLabel2.ForeColor = Color.Blue;
                    blackToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = true;
                    redToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    break;
                case "Red":
                    toolStripStatusLabel2.ForeColor = Color.Red;
                    blackToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = true;
                    greenToolStripMenuItem.Checked = false;
                    break;
                case "Green":
                    toolStripStatusLabel2.ForeColor = Color.Green;
                    blackToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker date = (DateTimePicker)sender;
            toolStripStatusLabel2.Text = date.Value.Date.ToString("dd/MM/yyyy") + " " + DateTime.Today.ToShortTimeString();
        }

        private void fontItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            textFont = i.Text;
            switch (i.Text)
            {
                case "Times New Roman":
                    timesNewRomanToolStripMenuItem.Checked = true;
                    courierToolStripMenuItem.Checked = false;
                    comicSansToolStripMenuItem.Checked = false;
                    break;
                case "Courier":
                    timesNewRomanToolStripMenuItem.Checked = false;
                    courierToolStripMenuItem.Checked = true;
                    comicSansToolStripMenuItem.Checked = false;
                    break;
                case "Comic Sans MS":
                    timesNewRomanToolStripMenuItem.Checked = false;
                    courierToolStripMenuItem.Checked = false;
                    comicSansToolStripMenuItem.Checked = true;
                    break;
            }
            fontSetter();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblTodaysDate_Click(object sender, EventArgs e)
        {

        }

        private void fontSetter()
        {
            toolStripStatusLabel2.Font = new System.Drawing.Font(textFont, (float) 8.25, (Style1 | Style2));
        }

        private void boldToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (Style1 == FontStyle.Regular)
            {
                Style1 = FontStyle.Bold;
                boldToolStripMenuItem.Checked = true;
            }
            else
            {
                Style1 = FontStyle.Regular;
                boldToolStripMenuItem.Checked = false;
            }
            fontSetter();
        }

        private void italicToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (Style2 == FontStyle.Regular)
            {
                Style2 = FontStyle.Italic;
                italicToolStripMenuItem.Checked = true;
            }
            else
            {
                Style2 = FontStyle.Regular;
                italicToolStripMenuItem.Checked = false;
            }
            fontSetter();
        }
    }
}
