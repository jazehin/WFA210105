namespace feladat13_07
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
            this.lblFormat = new System.Windows.Forms.Label();
            this.chbxFelkover = new System.Windows.Forms.CheckBox();
            this.chbxDolt = new System.Windows.Forms.CheckBox();
            this.chbxAlahuzott = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFormat
            // 
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormat.Location = new System.Drawing.Point(26, 9);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(146, 67);
            this.lblFormat.TabIndex = 0;
            this.lblFormat.Text = "A szó elszáll, az írás megmarad.";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chbxFelkover
            // 
            this.chbxFelkover.AutoSize = true;
            this.chbxFelkover.Location = new System.Drawing.Point(59, 79);
            this.chbxFelkover.Name = "chbxFelkover";
            this.chbxFelkover.Size = new System.Drawing.Size(67, 17);
            this.chbxFelkover.TabIndex = 1;
            this.chbxFelkover.Text = "Félkövér";
            this.chbxFelkover.UseVisualStyleBackColor = true;
            this.chbxFelkover.Click += new System.EventHandler(this.ChbxChanged);
            // 
            // chbxDolt
            // 
            this.chbxDolt.AutoSize = true;
            this.chbxDolt.Location = new System.Drawing.Point(59, 102);
            this.chbxDolt.Name = "chbxDolt";
            this.chbxDolt.Size = new System.Drawing.Size(45, 17);
            this.chbxDolt.TabIndex = 1;
            this.chbxDolt.Text = "Dőlt";
            this.chbxDolt.UseVisualStyleBackColor = true;
            this.chbxDolt.Click += new System.EventHandler(this.ChbxChanged);
            // 
            // chbxAlahuzott
            // 
            this.chbxAlahuzott.AutoSize = true;
            this.chbxAlahuzott.Location = new System.Drawing.Point(59, 125);
            this.chbxAlahuzott.Name = "chbxAlahuzott";
            this.chbxAlahuzott.Size = new System.Drawing.Size(70, 17);
            this.chbxAlahuzott.TabIndex = 1;
            this.chbxAlahuzott.Text = "Aláhúzott";
            this.chbxAlahuzott.UseVisualStyleBackColor = true;
            this.chbxAlahuzott.Click += new System.EventHandler(this.ChbxChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 157);
            this.Controls.Add(this.chbxAlahuzott);
            this.Controls.Add(this.chbxDolt);
            this.Controls.Add(this.chbxFelkover);
            this.Controls.Add(this.lblFormat);
            this.Name = "Form1";
            this.Text = "Betű stílusok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.CheckBox chbxFelkover;
        private System.Windows.Forms.CheckBox chbxDolt;
        private System.Windows.Forms.CheckBox chbxAlahuzott;
    }
}

