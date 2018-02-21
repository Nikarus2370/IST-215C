namespace Lab9_Buttons_with_Images
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNH = new System.Windows.Forms.Button();
            this.btnMass = new System.Windows.Forms.Button();
            this.btnVT = new System.Windows.Forms.Button();
            this.btnLD = new System.Windows.Forms.Button();
            this.btnRD = new System.Windows.Forms.Button();
            this.btnWA = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNH
            // 
            this.btnNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNH.Image = ((System.Drawing.Image)(resources.GetObject("btnNH.Image")));
            this.btnNH.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNH.Location = new System.Drawing.Point(12, 12);
            this.btnNH.Name = "btnNH";
            this.btnNH.Size = new System.Drawing.Size(129, 85);
            this.btnNH.TabIndex = 0;
            this.btnNH.Text = "New Hampshire";
            this.btnNH.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNH.UseVisualStyleBackColor = true;
            this.btnNH.Click += new System.EventHandler(this.btnNH_Click);
            // 
            // btnMass
            // 
            this.btnMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMass.Image = ((System.Drawing.Image)(resources.GetObject("btnMass.Image")));
            this.btnMass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMass.Location = new System.Drawing.Point(12, 103);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(129, 85);
            this.btnMass.TabIndex = 1;
            this.btnMass.Text = "Massachusetts";
            this.btnMass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMass.UseVisualStyleBackColor = true;
            this.btnMass.Click += new System.EventHandler(this.btnMass_Click);
            // 
            // btnVT
            // 
            this.btnVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVT.Image = ((System.Drawing.Image)(resources.GetObject("btnVT.Image")));
            this.btnVT.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVT.Location = new System.Drawing.Point(12, 194);
            this.btnVT.Name = "btnVT";
            this.btnVT.Size = new System.Drawing.Size(129, 85);
            this.btnVT.TabIndex = 2;
            this.btnVT.Text = "Vermont";
            this.btnVT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVT.UseVisualStyleBackColor = true;
            this.btnVT.Click += new System.EventHandler(this.btnVT_Click);
            // 
            // btnLD
            // 
            this.btnLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLD.Image = ((System.Drawing.Image)(resources.GetObject("btnLD.Image")));
            this.btnLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLD.Location = new System.Drawing.Point(164, 12);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(129, 85);
            this.btnLD.TabIndex = 3;
            this.btnLD.Text = "Little Ducky";
            this.btnLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Click += new System.EventHandler(this.btnLD_Click);
            // 
            // btnRD
            // 
            this.btnRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRD.Image = ((System.Drawing.Image)(resources.GetObject("btnRD.Image")));
            this.btnRD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRD.Location = new System.Drawing.Point(164, 103);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(129, 85);
            this.btnRD.TabIndex = 4;
            this.btnRD.Text = "Red Devil";
            this.btnRD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // btnWA
            // 
            this.btnWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWA.Image = ((System.Drawing.Image)(resources.GetObject("btnWA.Image")));
            this.btnWA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWA.Location = new System.Drawing.Point(164, 194);
            this.btnWA.Name = "btnWA";
            this.btnWA.Size = new System.Drawing.Size(129, 85);
            this.btnWA.TabIndex = 5;
            this.btnWA.Text = "White Alien";
            this.btnWA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWA.UseVisualStyleBackColor = true;
            this.btnWA.Click += new System.EventHandler(this.btnWA_Click);
            // 
            // lblOut
            // 
            this.lblOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblOut.Location = new System.Drawing.Point(12, 296);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(280, 33);
            this.lblOut.TabIndex = 6;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOut.Click += new System.EventHandler(this.lblOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 338);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnWA);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.btnLD);
            this.Controls.Add(this.btnVT);
            this.Controls.Add(this.btnMass);
            this.Controls.Add(this.btnNH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNH;
        private System.Windows.Forms.Button btnMass;
        private System.Windows.Forms.Button btnVT;
        private System.Windows.Forms.Button btnLD;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button btnWA;
        private System.Windows.Forms.Label lblOut;
    }
}

