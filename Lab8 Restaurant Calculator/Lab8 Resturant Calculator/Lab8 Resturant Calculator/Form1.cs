using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Resturant_Calculator
{
    public partial class frm_RestaurantBillcalculatorForm : Form
    {
        private decimal subtotal = 0M;
        private string output;

        private static Dictionary<string, decimal> beverages = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Soda", 1.95m },
            { "Tea", 1.50m },
            { "Coffee", 1.25m },
            { "Mineral Water", 2.95m },
            { "Juice", 2.50m },
            { "Milk", 1.50m }
        };

        private static Dictionary<string, decimal> appetizers = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Buffalo Wings", 5.95m },
            { "Buffalo Fingers", 6.95m },
            { "Potato Skins", 8.95m },
            { "Nachos", 8.95m },
            { "Mushroom Caps", 10.95m },
            { "Shrimp Cocktail", 12.95m },
            { "Chips and Salsa", 6.95m }
        };

        private static Dictionary<string, decimal> mainCourses = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Seafood Alfredo", 15.95m },
            { "Chicken Alfredo", 13.95m },
            { "Chicken Picatta", 13.95m },
            { "Turkey Club", 11.95m },
            { "Lobster Pie", 19.95m },
            { "Prime Rib", 20.95m },
            { "Shrimp Scampi", 18.95m },
            { "Turkey Dinner", 13.95m },
            { "Stuffed Chicken", 14.95m }
        };

        private static Dictionary<string, decimal> desserts = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Apple Pie", 5.95m },
            { "Sundae", 3.95m },
            { "Carrot Cake", 5.95m },
            { "Mud Pie", 4.95m },
            { "Apple Crisp", 5.95m }
        };


        public frm_RestaurantBillcalculatorForm()
        {
            InitializeComponent();
        }

        public void LoadCategory(string categoryString, ComboBox categoryCombo)
        {
            List<string> items = null;

            switch(categoryString)
            {
                case "Beverage":
                    items = beverages.Keys.ToList();
                    break;
                case "Appetizer":
                    items = appetizers.Keys.ToList();
                    break;
                case "Main Course":
                    items = mainCourses.Keys.ToList();
                    break;
                default:
                    items = desserts.Keys.ToList();
                    break;
            }

            categoryCombo.Items.AddRange(items.ToArray());
        }

        private void cb_Beverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cb_Beverage.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Beverage", selectedItem);
            output += "\r\n";
            rtx_Output.Text = output;
        }

        private void cb_Appetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cb_Appetizer.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Appetizer", selectedItem);
            output += "\r\n";
            rtx_Output.Text = output;
        }

        private void cb_MainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cb_MainCourse.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Main Course", selectedItem);
            output += "\r\n";
            rtx_Output.Text = output;
        }
        
        private void cb_Dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cb_Dessert.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Dessert", selectedItem);
            output += "\r\n";
            rtx_Output.Text = output;
        }

        private void AddToSubtotal(string category, string name)
        {
            Dictionary<string, decimal> items = null;

            switch(category)
            {
                case "Beverage":
                    items = beverages;
                    break;
                case "Appetizer":
                    items = appetizers;
                    break;
                case "Main Course":
                    items = mainCourses;
                    break;
                default:
                    items = desserts;
                    break;
            }

            foreach (var item in items)
            {
                if (item.Key == name)
                {
                    subtotal += item.Value;
                }
            }

            tb_SubTotal.Text = string.Format($"{subtotal:C}");
            tb_Tax.Text = string.Format($"{(subtotal * 0.05m):C}");
            tb_Total.Text = string.Format($"{(subtotal * 1.05m):C}");
        }

        private void btn_ClearBill_Click(object sender, EventArgs e)
        {
            subtotal = 0m;

            tb_SubTotal.Text = $"{0m:C}";
            tb_Tax.Text = $"{0m:C}";
            tb_Total.Text = $"{0m:C}";
            rtx_Output.Text = "";
            output = "";
        }

        private void frm_RestaurantBillcalculatorForm_Load_1(object sender, EventArgs e)
        {
            LoadCategory("Beverage", cb_Beverage);
            LoadCategory("Appetizer", cb_Appetizer);
            LoadCategory("Main Course", cb_MainCourse);
            LoadCategory("Dessert", cb_Dessert);
        }

        private void btn_TotalBill_Click(object sender, EventArgs e)
        {
            rtx_Output.Text = "While it is a bit strange. The supplied code for this assignment doesn't actually cover what we're supposed to do with this \"Total Bill\" button. So I just made it output this text";
            output = "";
        }
    }
}
