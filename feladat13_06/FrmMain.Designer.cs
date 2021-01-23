namespace feladat13_06
{
    partial class FrmMain
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
            this.rbtnEladas = new System.Windows.Forms.RadioButton();
            this.rbtnVetel = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxArfolyam = new System.Windows.Forms.TextBox();
            this.lblOsszeg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.tbxOsszeg = new System.Windows.Forms.TextBox();
            this.tbxEredmeny = new System.Windows.Forms.TextBox();
            this.cbxValuta = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblValuta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnEladas
            // 
            this.rbtnEladas.AutoSize = true;
            this.rbtnEladas.Location = new System.Drawing.Point(171, 23);
            this.rbtnEladas.Name = "rbtnEladas";
            this.rbtnEladas.Size = new System.Drawing.Size(57, 17);
            this.rbtnEladas.TabIndex = 1;
            this.rbtnEladas.Text = "Eladás";
            this.rbtnEladas.UseVisualStyleBackColor = true;
            this.rbtnEladas.Click += new System.EventHandler(this.RbtnClick);
            // 
            // rbtnVetel
            // 
            this.rbtnVetel.AutoSize = true;
            this.rbtnVetel.Checked = true;
            this.rbtnVetel.Location = new System.Drawing.Point(80, 23);
            this.rbtnVetel.Name = "rbtnVetel";
            this.rbtnVetel.Size = new System.Drawing.Size(49, 17);
            this.rbtnVetel.TabIndex = 2;
            this.rbtnVetel.TabStop = true;
            this.rbtnVetel.Text = "Vétel";
            this.rbtnVetel.UseVisualStyleBackColor = true;
            this.rbtnVetel.Click += new System.EventHandler(this.RbtnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ft";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valuta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Árfolyam:";
            // 
            // tbxArfolyam
            // 
            this.tbxArfolyam.Enabled = false;
            this.tbxArfolyam.Location = new System.Drawing.Point(110, 97);
            this.tbxArfolyam.Name = "tbxArfolyam";
            this.tbxArfolyam.Size = new System.Drawing.Size(128, 20);
            this.tbxArfolyam.TabIndex = 6;
            // 
            // lblOsszeg
            // 
            this.lblOsszeg.AutoSize = true;
            this.lblOsszeg.Location = new System.Drawing.Point(12, 138);
            this.lblOsszeg.Name = "lblOsszeg";
            this.lblOsszeg.Size = new System.Drawing.Size(92, 13);
            this.lblOsszeg.TabIndex = 5;
            this.lblOsszeg.Text = "Vásárlás összege:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ft";
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Location = new System.Drawing.Point(48, 175);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(56, 13);
            this.lblEredmeny.TabIndex = 5;
            this.lblEredmeny.Text = "Fizetendő:";
            // 
            // tbxOsszeg
            // 
            this.tbxOsszeg.Location = new System.Drawing.Point(110, 135);
            this.tbxOsszeg.Name = "tbxOsszeg";
            this.tbxOsszeg.Size = new System.Drawing.Size(128, 20);
            this.tbxOsszeg.TabIndex = 6;
            this.tbxOsszeg.TextChanged += new System.EventHandler(this.TbxOsszegChanged);
            // 
            // tbxEredmeny
            // 
            this.tbxEredmeny.Enabled = false;
            this.tbxEredmeny.Location = new System.Drawing.Point(110, 172);
            this.tbxEredmeny.Name = "tbxEredmeny";
            this.tbxEredmeny.Size = new System.Drawing.Size(128, 20);
            this.tbxEredmeny.TabIndex = 6;
            // 
            // cbxValuta
            // 
            this.cbxValuta.FormattingEnabled = true;
            this.cbxValuta.Location = new System.Drawing.Point(110, 60);
            this.cbxValuta.Name = "cbxValuta";
            this.cbxValuta.Size = new System.Drawing.Size(128, 21);
            this.cbxValuta.TabIndex = 7;
            this.cbxValuta.SelectedIndexChanged += new System.EventHandler(this.CbxValutaChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(110, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 32);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOKClicked);
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(244, 138);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(16, 13);
            this.lblValuta.TabIndex = 4;
            this.lblValuta.Text = "...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 264);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxValuta);
            this.Controls.Add(this.tbxEredmeny);
            this.Controls.Add(this.tbxOsszeg);
            this.Controls.Add(this.tbxArfolyam);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOsszeg);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnEladas);
            this.Controls.Add(this.rbtnVetel);
            this.Name = "FrmMain";
            this.Text = "Valuta váltó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnEladas;
        private System.Windows.Forms.RadioButton rbtnVetel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxArfolyam;
        private System.Windows.Forms.Label lblOsszeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEredmeny;
        private System.Windows.Forms.TextBox tbxOsszeg;
        private System.Windows.Forms.TextBox tbxEredmeny;
        private System.Windows.Forms.ComboBox cbxValuta;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblValuta;
    }
}

