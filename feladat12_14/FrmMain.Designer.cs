namespace feladat12_14
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
            this.tbxA = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Egyik befogó:";
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(105, 6);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(131, 20);
            this.tbxA.TabIndex = 1;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(255, 17);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(96, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Kiszámol";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCountClick);
            // 
            // lbxResult
            // 
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.Location = new System.Drawing.Point(15, 76);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(221, 160);
            this.lbxResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Másik befogó:";
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(105, 32);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(131, 20);
            this.tbxB.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 252);
            this.Controls.Add(this.lbxResult);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxA);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Pitagorasz tétel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ListBox lbxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxB;
    }
}

