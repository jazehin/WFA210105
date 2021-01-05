namespace feladatok12_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.btnDivisors = new System.Windows.Forms.Button();
            this.lbxDivisors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szám:";
            // 
            // tbxNum
            // 
            this.tbxNum.Location = new System.Drawing.Point(65, 10);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(98, 20);
            this.tbxNum.TabIndex = 1;
            // 
            // btnDivisors
            // 
            this.btnDivisors.Location = new System.Drawing.Point(180, 8);
            this.btnDivisors.Name = "btnDivisors";
            this.btnDivisors.Size = new System.Drawing.Size(111, 23);
            this.btnDivisors.TabIndex = 2;
            this.btnDivisors.Text = "Osztók";
            this.btnDivisors.UseVisualStyleBackColor = true;
            this.btnDivisors.Click += new System.EventHandler(this.BtnDivisorsClick);
            // 
            // lbxDivisors
            // 
            this.lbxDivisors.FormattingEnabled = true;
            this.lbxDivisors.Location = new System.Drawing.Point(16, 39);
            this.lbxDivisors.Name = "lbxDivisors";
            this.lbxDivisors.Size = new System.Drawing.Size(147, 225);
            this.lbxDivisors.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 280);
            this.Controls.Add(this.lbxDivisors);
            this.Controls.Add(this.btnDivisors);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Osztók";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Button btnDivisors;
        private System.Windows.Forms.ListBox lbxDivisors;
    }
}

