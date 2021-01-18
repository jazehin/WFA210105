namespace feladat13_03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxSzint = new System.Windows.Forms.ComboBox();
            this.cbxNyelv = new System.Windows.Forms.ComboBox();
            this.tbxEv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbxSzint);
            this.groupBox1.Controls.Add(this.cbxNyelv);
            this.groupBox1.Controls.Add(this.tbxEv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxNev);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Adatbevitel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnAdatbevitelClick);
            // 
            // cbxSzint
            // 
            this.cbxSzint.FormattingEnabled = true;
            this.cbxSzint.Items.AddRange(new object[] {
            "kezdő",
            "középhaladó",
            "haladó"});
            this.cbxSzint.Location = new System.Drawing.Point(105, 124);
            this.cbxSzint.Name = "cbxSzint";
            this.cbxSzint.Size = new System.Drawing.Size(121, 21);
            this.cbxSzint.TabIndex = 2;
            // 
            // cbxNyelv
            // 
            this.cbxNyelv.FormattingEnabled = true;
            this.cbxNyelv.Items.AddRange(new object[] {
            "angol",
            "német",
            "francia"});
            this.cbxNyelv.Location = new System.Drawing.Point(105, 93);
            this.cbxNyelv.Name = "cbxNyelv";
            this.cbxNyelv.Size = new System.Drawing.Size(121, 21);
            this.cbxNyelv.TabIndex = 2;
            // 
            // tbxEv
            // 
            this.tbxEv.Location = new System.Drawing.Point(105, 60);
            this.tbxEv.MaxLength = 4;
            this.tbxEv.Name = "tbxEv";
            this.tbxEv.Size = new System.Drawing.Size(100, 20);
            this.tbxEv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Szint:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Születési év:";
            // 
            // tbxNev
            // 
            this.tbxNev.Location = new System.Drawing.Point(105, 29);
            this.tbxNev.Name = "tbxNev";
            this.tbxNev.Size = new System.Drawing.Size(158, 20);
            this.tbxNev.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nyelv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Válogatás, kiírás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnValogatasClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nyelvtanfolyam - jelentkezés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxSzint;
        private System.Windows.Forms.ComboBox cbxNyelv;
        private System.Windows.Forms.TextBox tbxEv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

