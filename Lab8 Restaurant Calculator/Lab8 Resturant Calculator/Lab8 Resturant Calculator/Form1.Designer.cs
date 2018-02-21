namespace Lab8_Resturant_Calculator
{
    partial class frm_RestaurantBillcalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ClearBill = new System.Windows.Forms.Button();
            this.btn_TotalBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_MenuItems = new System.Windows.Forms.GroupBox();
            this.cb_Beverage = new System.Windows.Forms.ComboBox();
            this.cb_Appetizer = new System.Windows.Forms.ComboBox();
            this.cb_MainCourse = new System.Windows.Forms.ComboBox();
            this.cb_Dessert = new System.Windows.Forms.ComboBox();
            this.gb_WaiterInformation = new System.Windows.Forms.GroupBox();
            this.cb_WaiterName = new System.Windows.Forms.ComboBox();
            this.tb_TableNumber = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Tax = new System.Windows.Forms.TextBox();
            this.tb_SubTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtx_Output = new System.Windows.Forms.RichTextBox();
            this.gb_MenuItems.SuspendLayout();
            this.gb_WaiterInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ClearBill
            // 
            this.btn_ClearBill.Location = new System.Drawing.Point(275, 314);
            this.btn_ClearBill.Name = "btn_ClearBill";
            this.btn_ClearBill.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearBill.TabIndex = 0;
            this.btn_ClearBill.Text = "Clear Bill";
            this.btn_ClearBill.UseVisualStyleBackColor = true;
            this.btn_ClearBill.Click += new System.EventHandler(this.btn_ClearBill_Click);
            // 
            // btn_TotalBill
            // 
            this.btn_TotalBill.Location = new System.Drawing.Point(401, 314);
            this.btn_TotalBill.Name = "btn_TotalBill";
            this.btn_TotalBill.Size = new System.Drawing.Size(75, 23);
            this.btn_TotalBill.TabIndex = 1;
            this.btn_TotalBill.Text = "Total Bill";
            this.btn_TotalBill.UseVisualStyleBackColor = true;
            this.btn_TotalBill.Click += new System.EventHandler(this.btn_TotalBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Beverage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Appetizer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Main Course:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dessert:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Table number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Waiter\'s name";
            // 
            // gb_MenuItems
            // 
            this.gb_MenuItems.Controls.Add(this.cb_Beverage);
            this.gb_MenuItems.Controls.Add(this.cb_Appetizer);
            this.gb_MenuItems.Controls.Add(this.cb_MainCourse);
            this.gb_MenuItems.Controls.Add(this.cb_Dessert);
            this.gb_MenuItems.Controls.Add(this.label5);
            this.gb_MenuItems.Controls.Add(this.label4);
            this.gb_MenuItems.Controls.Add(this.label6);
            this.gb_MenuItems.Controls.Add(this.label7);
            this.gb_MenuItems.Location = new System.Drawing.Point(12, 48);
            this.gb_MenuItems.Name = "gb_MenuItems";
            this.gb_MenuItems.Size = new System.Drawing.Size(223, 142);
            this.gb_MenuItems.TabIndex = 11;
            this.gb_MenuItems.TabStop = false;
            this.gb_MenuItems.Text = "Menu Items";
            // 
            // cb_Beverage
            // 
            this.cb_Beverage.FormattingEnabled = true;
            this.cb_Beverage.Location = new System.Drawing.Point(96, 25);
            this.cb_Beverage.Name = "cb_Beverage";
            this.cb_Beverage.Size = new System.Drawing.Size(121, 21);
            this.cb_Beverage.TabIndex = 15;
            this.cb_Beverage.SelectedIndexChanged += new System.EventHandler(this.cb_Beverage_SelectedIndexChanged);
            // 
            // cb_Appetizer
            // 
            this.cb_Appetizer.FormattingEnabled = true;
            this.cb_Appetizer.Location = new System.Drawing.Point(96, 53);
            this.cb_Appetizer.Name = "cb_Appetizer";
            this.cb_Appetizer.Size = new System.Drawing.Size(121, 21);
            this.cb_Appetizer.TabIndex = 14;
            this.cb_Appetizer.SelectedIndexChanged += new System.EventHandler(this.cb_Appetizer_SelectedIndexChanged);
            // 
            // cb_MainCourse
            // 
            this.cb_MainCourse.FormattingEnabled = true;
            this.cb_MainCourse.Location = new System.Drawing.Point(96, 80);
            this.cb_MainCourse.Name = "cb_MainCourse";
            this.cb_MainCourse.Size = new System.Drawing.Size(121, 21);
            this.cb_MainCourse.TabIndex = 13;
            this.cb_MainCourse.SelectedIndexChanged += new System.EventHandler(this.cb_MainCourse_SelectedIndexChanged);
            // 
            // cb_Dessert
            // 
            this.cb_Dessert.FormattingEnabled = true;
            this.cb_Dessert.Location = new System.Drawing.Point(96, 107);
            this.cb_Dessert.Name = "cb_Dessert";
            this.cb_Dessert.Size = new System.Drawing.Size(121, 21);
            this.cb_Dessert.TabIndex = 16;
            this.cb_Dessert.SelectedIndexChanged += new System.EventHandler(this.cb_Dessert_SelectedIndexChanged);
            // 
            // gb_WaiterInformation
            // 
            this.gb_WaiterInformation.Controls.Add(this.cb_WaiterName);
            this.gb_WaiterInformation.Controls.Add(this.tb_TableNumber);
            this.gb_WaiterInformation.Controls.Add(this.label8);
            this.gb_WaiterInformation.Controls.Add(this.label9);
            this.gb_WaiterInformation.Location = new System.Drawing.Point(265, 48);
            this.gb_WaiterInformation.Name = "gb_WaiterInformation";
            this.gb_WaiterInformation.Size = new System.Drawing.Size(211, 87);
            this.gb_WaiterInformation.TabIndex = 18;
            this.gb_WaiterInformation.TabStop = false;
            this.gb_WaiterInformation.Text = "Waiter Information";
            // 
            // cb_WaiterName
            // 
            this.cb_WaiterName.FormattingEnabled = true;
            this.cb_WaiterName.Items.AddRange(new object[] {
            "Johnny Flash",
            "Rosy Mitchell",
            "Jacki Johnson",
            "Jake Summers"});
            this.cb_WaiterName.Location = new System.Drawing.Point(81, 52);
            this.cb_WaiterName.Name = "cb_WaiterName";
            this.cb_WaiterName.Size = new System.Drawing.Size(121, 21);
            this.cb_WaiterName.TabIndex = 12;
            // 
            // tb_TableNumber
            // 
            this.tb_TableNumber.Location = new System.Drawing.Point(81, 25);
            this.tb_TableNumber.Name = "tb_TableNumber";
            this.tb_TableNumber.Size = new System.Drawing.Size(72, 20);
            this.tb_TableNumber.TabIndex = 17;
            this.tb_TableNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(376, 271);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.ReadOnly = true;
            this.tb_Total.Size = new System.Drawing.Size(100, 20);
            this.tb_Total.TabIndex = 14;
            this.tb_Total.Text = "$0.00";
            this.tb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Tax
            // 
            this.tb_Tax.Location = new System.Drawing.Point(376, 243);
            this.tb_Tax.Name = "tb_Tax";
            this.tb_Tax.ReadOnly = true;
            this.tb_Tax.Size = new System.Drawing.Size(100, 20);
            this.tb_Tax.TabIndex = 15;
            this.tb_Tax.Text = "$0.00";
            this.tb_Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_SubTotal
            // 
            this.tb_SubTotal.Location = new System.Drawing.Point(376, 217);
            this.tb_SubTotal.Name = "tb_SubTotal";
            this.tb_SubTotal.ReadOnly = true;
            this.tb_SubTotal.Size = new System.Drawing.Size(100, 20);
            this.tb_SubTotal.TabIndex = 16;
            this.tb_SubTotal.Text = "$0.00";
            this.tb_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Roadside Restaurant";
            // 
            // rtx_Output
            // 
            this.rtx_Output.Location = new System.Drawing.Point(12, 197);
            this.rtx_Output.Name = "rtx_Output";
            this.rtx_Output.Size = new System.Drawing.Size(223, 156);
            this.rtx_Output.TabIndex = 19;
            this.rtx_Output.Text = "";
            // 
            // frm_RestaurantBillcalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 365);
            this.Controls.Add(this.rtx_Output);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_SubTotal);
            this.Controls.Add(this.tb_Tax);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.gb_WaiterInformation);
            this.Controls.Add(this.gb_MenuItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TotalBill);
            this.Controls.Add(this.btn_ClearBill);
            this.Name = "frm_RestaurantBillcalculatorForm";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.frm_RestaurantBillcalculatorForm_Load_1);
            this.gb_MenuItems.ResumeLayout(false);
            this.gb_MenuItems.PerformLayout();
            this.gb_WaiterInformation.ResumeLayout(false);
            this.gb_WaiterInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ClearBill;
        private System.Windows.Forms.Button btn_TotalBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_MenuItems;
        private System.Windows.Forms.ComboBox cb_Beverage;
        private System.Windows.Forms.ComboBox cb_Appetizer;
        private System.Windows.Forms.ComboBox cb_MainCourse;
        private System.Windows.Forms.ComboBox cb_Dessert;
        private System.Windows.Forms.GroupBox gb_WaiterInformation;
        private System.Windows.Forms.ComboBox cb_WaiterName;
        private System.Windows.Forms.TextBox tb_TableNumber;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Tax;
        private System.Windows.Forms.TextBox tb_SubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtx_Output;
    }
}

