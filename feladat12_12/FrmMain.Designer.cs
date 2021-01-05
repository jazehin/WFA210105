namespace feladat12_12
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
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(13, 13);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(39, 20);
            this.tbxA.TabIndex = 0;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(97, 13);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(39, 20);
            this.tbxB.TabIndex = 0;
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(169, 13);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(39, 20);
            this.tbxC.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 39);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(106, 23);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Kiszámol";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCountClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x^2 +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "= 0";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(12, 77);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(30, 13);
            this.lblX1.TabIndex = 5;
            this.lblX1.Text = "x1 = ";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(12, 99);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(30, 13);
            this.lblX2.TabIndex = 6;
            this.lblX2.Text = "x2 = ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 124);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxA);
            this.Name = "FrmMain";
            this.Text = "Másodfokú egyenlet megoldása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
    }
}

