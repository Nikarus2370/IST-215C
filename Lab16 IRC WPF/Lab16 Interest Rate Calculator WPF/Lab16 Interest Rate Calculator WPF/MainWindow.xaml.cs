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

namespace Lab16_Interest_Rate_Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentFrequency = 12;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton) sender;
            string val = rb.Name.ToString();
            switch (val)
            {
                case "rbtn_Monthly":
                    currentFrequency = 12;
                    break;
                case "rbtn_Quarterly":
                    currentFrequency = 4;
                    break;
                case "rbtn_SemiAnnually":
                    currentFrequency = 2;
                    break;
                case "rbtn_Annually":
                    currentFrequency = 1;
                    break;
            }
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            Decimal principal;
            Decimal interestRate;
            Decimal years;
            int intervals;
            Decimal balance;
            Decimal intEarn;


            try
            {
                principal = Decimal.Parse(tb_Principle.Text, System.Globalization.NumberStyles.Currency);

                if (principal <= 0)
                {
                    throw new FormatException("Principal amount must be greater than 0.");
                }
                interestRate = Decimal.Parse(tb_Interest.Text);
                if (interestRate < 0)
                {
                    throw new ApplicationException("Interest rate must be greater than or equal to 0.");
                }
                years = Decimal.Parse(tb_Years.Text);
                if (years < 0)
                {
                    throw new ApplicationException("Number of years to compound interest must be greater than or equal to 0.");
                }
                intervals = currentFrequency;


                tb_Principle.Text = principal.ToString("C");
                Decimal insideParen = (1 + (interestRate / 100) / intervals);
                Decimal exponent = (intervals * years);


                balance = principal * (decimal)Math.Pow((double)insideParen, (double)exponent);
                intEarn = balance - principal;

                tb_CurrentValue.Text = String.Format("{0:C}", balance);
                tb_InterestEarned.Text = String.Format("{0:C}" , intEarn);
            }
            catch (Exception)
            {
                MessageBox.Show("Error in numeric input. Please check that inputs are entered without special characters such as \"$\"", "Error has occurred", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
