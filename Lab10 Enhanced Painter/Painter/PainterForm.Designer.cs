namespace Painter
{
   partial class PainterForm
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
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSL = new System.Windows.Forms.RadioButton();
            this.rbtnSM = new System.Windows.Forms.RadioButton();
            this.rbtnSS = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCBlack = new System.Windows.Forms.RadioButton();
            this.rbtnCGreen = new System.Windows.Forms.RadioButton();
            this.rbtnCBlue = new System.Windows.Forms.RadioButton();
            this.rbtnCRed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDraw.Location = new System.Drawing.Point(146, 18);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(324, 236);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseMove);
            this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSL);
            this.groupBox1.Controls.Add(this.rbtnSM);
            this.groupBox1.Controls.Add(this.rbtnSS);
            this.groupBox1.Location = new System.Drawing.Point(14, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rbtnSL
            // 
            this.rbtnSL.AutoSize = true;
            this.rbtnSL.Location = new System.Drawing.Point(6, 72);
            this.rbtnSL.Name = "rbtnSL";
            this.rbtnSL.Size = new System.Drawing.Size(54, 19);
            this.rbtnSL.TabIndex = 2;
            this.rbtnSL.Text = "Large";
            this.rbtnSL.UseVisualStyleBackColor = true;
            this.rbtnSL.CheckedChanged += new System.EventHandler(this.rbtnSize_CheckedChanged);
            // 
            // rbtnSM
            // 
            this.rbtnSM.AutoSize = true;
            this.rbtnSM.Location = new System.Drawing.Point(6, 47);
            this.rbtnSM.Name = "rbtnSM";
            this.rbtnSM.Size = new System.Drawing.Size(70, 19);
            this.rbtnSM.TabIndex = 1;
            this.rbtnSM.Text = "Medium";
            this.rbtnSM.UseVisualStyleBackColor = true;
            this.rbtnSM.CheckedChanged += new System.EventHandler(this.rbtnSize_CheckedChanged);
            // 
            // rbtnSS
            // 
            this.rbtnSS.AutoSize = true;
            this.rbtnSS.Checked = true;
            this.rbtnSS.Location = new System.Drawing.Point(6, 22);
            this.rbtnSS.Name = "rbtnSS";
            this.rbtnSS.Size = new System.Drawing.Size(54, 19);
            this.rbtnSS.TabIndex = 0;
            this.rbtnSS.TabStop = true;
            this.rbtnSS.Text = "Small";
            this.rbtnSS.UseVisualStyleBackColor = true;
            this.rbtnSS.CheckedChanged += new System.EventHandler(this.rbtnSize_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCBlack);
            this.groupBox2.Controls.Add(this.rbtnCGreen);
            this.groupBox2.Controls.Add(this.rbtnCBlue);
            this.groupBox2.Controls.Add(this.rbtnCRed);
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // rbtnCBlack
            // 
            this.rbtnCBlack.AutoSize = true;
            this.rbtnCBlack.Location = new System.Drawing.Point(12, 100);
            this.rbtnCBlack.Name = "rbtnCBlack";
            this.rbtnCBlack.Size = new System.Drawing.Size(53, 19);
            this.rbtnCBlack.TabIndex = 3;
            this.rbtnCBlack.TabStop = true;
            this.rbtnCBlack.Text = "Black";
            this.rbtnCBlack.UseVisualStyleBackColor = true;
            this.rbtnCBlack.CheckedChanged += new System.EventHandler(this.rbtnColor_CheckedChanged);
            // 
            // rbtnCGreen
            // 
            this.rbtnCGreen.AutoSize = true;
            this.rbtnCGreen.Location = new System.Drawing.Point(12, 75);
            this.rbtnCGreen.Name = "rbtnCGreen";
            this.rbtnCGreen.Size = new System.Drawing.Size(56, 19);
            this.rbtnCGreen.TabIndex = 2;
            this.rbtnCGreen.TabStop = true;
            this.rbtnCGreen.Text = "Green";
            this.rbtnCGreen.UseVisualStyleBackColor = true;
            this.rbtnCGreen.CheckedChanged += new System.EventHandler(this.rbtnColor_CheckedChanged);
            // 
            // rbtnCBlue
            // 
            this.rbtnCBlue.AutoSize = true;
            this.rbtnCBlue.Location = new System.Drawing.Point(12, 49);
            this.rbtnCBlue.Name = "rbtnCBlue";
            this.rbtnCBlue.Size = new System.Drawing.Size(48, 19);
            this.rbtnCBlue.TabIndex = 1;
            this.rbtnCBlue.TabStop = true;
            this.rbtnCBlue.Text = "Blue";
            this.rbtnCBlue.UseVisualStyleBackColor = true;
            this.rbtnCBlue.CheckedChanged += new System.EventHandler(this.rbtnColor_CheckedChanged);
            // 
            // rbtnCRed
            // 
            this.rbtnCRed.AutoSize = true;
            this.rbtnCRed.Checked = true;
            this.rbtnCRed.Location = new System.Drawing.Point(12, 22);
            this.rbtnCRed.Name = "rbtnCRed";
            this.rbtnCRed.Size = new System.Drawing.Size(45, 19);
            this.rbtnCRed.TabIndex = 0;
            this.rbtnCRed.TabStop = true;
            this.rbtnCRed.Text = "Red";
            this.rbtnCRed.UseVisualStyleBackColor = true;
            this.rbtnCRed.CheckedChanged += new System.EventHandler(this.rbtnColor_CheckedChanged);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlDraw);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PainterForm";
            this.Text = "Drawing Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSL;
        private System.Windows.Forms.RadioButton rbtnSM;
        private System.Windows.Forms.RadioButton rbtnSS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnCBlack;
        private System.Windows.Forms.RadioButton rbtnCGreen;
        private System.Windows.Forms.RadioButton rbtnCBlue;
        private System.Windows.Forms.RadioButton rbtnCRed;
    }
}

