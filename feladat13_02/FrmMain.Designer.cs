namespace feladat13_02
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
            this.cbxTípusok = new System.Windows.Forms.ComboBox();
            this.BtnSorsolás = new System.Windows.Forms.Button();
            this.lblEredmény = new System.Windows.Forms.Label();
            this.pbxSzamok = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSzamok)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTípusok
            // 
            this.cbxTípusok.FormattingEnabled = true;
            this.cbxTípusok.Items.AddRange(new object[] {
            "Ötöslottó",
            "Hatoslottó",
            "Skandináv lottó"});
            this.cbxTípusok.Location = new System.Drawing.Point(115, 29);
            this.cbxTípusok.Name = "cbxTípusok";
            this.cbxTípusok.Size = new System.Drawing.Size(121, 21);
            this.cbxTípusok.TabIndex = 0;
            this.cbxTípusok.SelectedIndexChanged += new System.EventHandler(this.LottoValtozott);
            // 
            // BtnSorsolás
            // 
            this.BtnSorsolás.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSorsolás.Location = new System.Drawing.Point(115, 68);
            this.BtnSorsolás.Name = "BtnSorsolás";
            this.BtnSorsolás.Size = new System.Drawing.Size(121, 29);
            this.BtnSorsolás.TabIndex = 1;
            this.BtnSorsolás.Text = "SORSOLÁS";
            this.BtnSorsolás.UseVisualStyleBackColor = true;
            this.BtnSorsolás.Click += new System.EventHandler(this.BtnSorsolasClick);
            // 
            // lblEredmény
            // 
            this.lblEredmény.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEredmény.Location = new System.Drawing.Point(12, 134);
            this.lblEredmény.Name = "lblEredmény";
            this.lblEredmény.Size = new System.Drawing.Size(328, 101);
            this.lblEredmény.TabIndex = 2;
            this.lblEredmény.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSzamok
            // 
            this.pbxSzamok.Image = global::feladat13_02.Properties.Resources.lottoszamok;
            this.pbxSzamok.InitialImage = null;
            this.pbxSzamok.Location = new System.Drawing.Point(12, 109);
            this.pbxSzamok.Name = "pbxSzamok";
            this.pbxSzamok.Size = new System.Drawing.Size(327, 148);
            this.pbxSzamok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSzamok.TabIndex = 3;
            this.pbxSzamok.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 269);
            this.Controls.Add(this.pbxSzamok);
            this.Controls.Add(this.lblEredmény);
            this.Controls.Add(this.BtnSorsolás);
            this.Controls.Add(this.cbxTípusok);
            this.Name = "Form1";
            this.Text = "LOTTÓ";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSzamok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTípusok;
        private System.Windows.Forms.Button BtnSorsolás;
        private System.Windows.Forms.Label lblEredmény;
        private System.Windows.Forms.PictureBox pbxSzamok;
    }
}

