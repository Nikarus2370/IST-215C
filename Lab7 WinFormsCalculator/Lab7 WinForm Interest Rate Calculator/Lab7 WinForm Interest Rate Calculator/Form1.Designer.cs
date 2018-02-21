namespace Lab7_WinForm_Interest_Rate_Calculator
{
    partial class frm_IntrestCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IntrestCalculator));
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Principal = new System.Windows.Forms.Label();
            this.lbl_InterestRate = new System.Windows.Forms.Label();
            this.lbl_Years = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.txt_Principal = new System.Windows.Forms.TextBox();
            this.nud_InterestRate = new System.Windows.Forms.NumericUpDown();
            this.nud_Year = new System.Windows.Forms.NumericUpDown();
            this.txt_Display = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_InterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Calculate.Location = new System.Drawing.Point(197, 13);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 0;
            this.btn_Calculate.Text = "&Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Clear.Location = new System.Drawing.Point(197, 47);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "C&lear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Principal
            // 
            this.lbl_Principal.AutoSize = true;
            this.lbl_Principal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Principal.Location = new System.Drawing.Point(35, 18);
            this.lbl_Principal.Name = "lbl_Principal";
            this.lbl_Principal.Size = new System.Drawing.Size(50, 13);
            this.lbl_Principal.TabIndex = 2;
            this.lbl_Principal.Text = "Principal:";
            // 
            // lbl_InterestRate
            // 
            this.lbl_InterestRate.AutoSize = true;
            this.lbl_InterestRate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_InterestRate.Location = new System.Drawing.Point(14, 49);
            this.lbl_InterestRate.Name = "lbl_InterestRate";
            this.lbl_InterestRate.Size = new System.Drawing.Size(71, 13);
            this.lbl_InterestRate.TabIndex = 3;
            this.lbl_InterestRate.Text = "Interest Rate:";
            // 
            // lbl_Years
            // 
            this.lbl_Years.AutoSize = true;
            this.lbl_Years.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Years.Location = new System.Drawing.Point(48, 75);
            this.lbl_Years.Name = "lbl_Years";
            this.lbl_Years.Size = new System.Drawing.Size(37, 13);
            this.lbl_Years.TabIndex = 4;
            this.lbl_Years.Text = "Years:";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Balance.Location = new System.Drawing.Point(12, 106);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(122, 13);
            this.lbl_Balance.TabIndex = 5;
            this.lbl_Balance.Text = "Yearly account balance:";
            // 
            // txt_Principal
            // 
            this.txt_Principal.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_Principal.Location = new System.Drawing.Point(91, 16);
            this.txt_Principal.Name = "txt_Principal";
            this.txt_Principal.Size = new System.Drawing.Size(100, 20);
            this.txt_Principal.TabIndex = 6;
            // 
            // nud_InterestRate
            // 
            this.nud_InterestRate.BackColor = System.Drawing.Color.AliceBlue;
            this.nud_InterestRate.DecimalPlaces = 2;
            this.nud_InterestRate.ForeColor = System.Drawing.Color.DarkBlue;
            this.nud_InterestRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nud_InterestRate.Location = new System.Drawing.Point(91, 47);
            this.nud_InterestRate.Name = "nud_InterestRate";
            this.nud_InterestRate.Size = new System.Drawing.Size(100, 20);
            this.nud_InterestRate.TabIndex = 7;
            // 
            // nud_Year
            // 
            this.nud_Year.BackColor = System.Drawing.Color.AliceBlue;
            this.nud_Year.DecimalPlaces = 3;
            this.nud_Year.ForeColor = System.Drawing.Color.DarkBlue;
            this.nud_Year.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_Year.Location = new System.Drawing.Point(91, 73);
            this.nud_Year.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_Year.Name = "nud_Year";
            this.nud_Year.Size = new System.Drawing.Size(100, 20);
            this.nud_Year.TabIndex = 8;
            this.nud_Year.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // txt_Display
            // 
            this.txt_Display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Display.Location = new System.Drawing.Point(12, 122);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Display.Size = new System.Drawing.Size(260, 124);
            this.txt_Display.TabIndex = 9;
            // 
            // frm_IntrestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(288, 258);
            this.Controls.Add(this.txt_Display);
            this.Controls.Add(this.nud_Year);
            this.Controls.Add(this.nud_InterestRate);
            this.Controls.Add(this.txt_Principal);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_Years);
            this.Controls.Add(this.lbl_InterestRate);
            this.Controls.Add(this.lbl_Principal);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_IntrestCalculator";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nud_InterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Principal;
        private System.Windows.Forms.Label lbl_InterestRate;
        private System.Windows.Forms.Label lbl_Years;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.TextBox txt_Principal;
        private System.Windows.Forms.NumericUpDown nud_InterestRate;
        private System.Windows.Forms.NumericUpDown nud_Year;
        private System.Windows.Forms.TextBox txt_Display;
    }
}

