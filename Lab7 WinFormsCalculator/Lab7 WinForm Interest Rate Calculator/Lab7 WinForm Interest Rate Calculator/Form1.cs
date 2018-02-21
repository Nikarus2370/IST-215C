using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_WinForm_Interest_Rate_Calculator
{
    public partial class frm_IntrestCalculator : Form
    {
        public frm_IntrestCalculator()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Decimal principal;
            Decimal interestRate;
            Decimal years;
            int intervals;
            Decimal balance;
            string display;
            

            try
            {
                principal = Decimal.Parse(txt_Principal.Text, System.Globalization.NumberStyles.Currency);

                if (principal <= 0)
                {
                    throw new FormatException("Principal amount must be greater than 0.");
                }
                interestRate = Decimal.Parse(nud_InterestRate.Text);
                if (interestRate < 0)
                {
                    throw new ApplicationException("Interest rate must be greater than or equal to 0.");
                }
                years = Decimal.Parse(nud_Year.Text);
                if (years < 0)
                {
                    throw new ApplicationException("Number of years to compound interest must be greater than or equal to 0.");
                }
                intervals = (int)(years * 2);
                balance = principal;
                display = "Year\tAmount on Deposit\r\n";


                txt_Principal.Text = principal.ToString("C");

                for (int i = 0; i < intervals; i++)
                {
                    balance = balance + (balance * (Decimal)0.5 * (interestRate / (Decimal)100));
                    display += $"{(i * 0.5 + 0.5)}\t{balance:C}\r\n";
                }

                txt_Display.Text = display;
            }
            catch (Exception)
            {
                MessageBox.Show("Thre is an invalid value in input field", "Interest Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Display.Text = string.Empty;
        }
    }
}
