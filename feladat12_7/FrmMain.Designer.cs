namespace feladat12_7
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
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hány kockadobást kérsz?";
            // 
            // tbxCount
            // 
            this.tbxCount.Location = new System.Drawing.Point(149, 6);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(102, 20);
            this.tbxCount.TabIndex = 1;
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(15, 32);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResult.Size = new System.Drawing.Size(236, 142);
            this.tbxResult.TabIndex = 2;
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(93, 182);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(75, 23);
            this.btnThrow.TabIndex = 3;
            this.btnThrow.Text = "Dobás";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.BtnThrowClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 217);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Kockadobások";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnThrow;
    }
}

