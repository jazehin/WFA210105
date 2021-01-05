namespace feladat12_3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAquamarine = new System.Windows.Forms.Label();
            this.lblLime = new System.Windows.Forms.Label();
            this.lblIndigo = new System.Windows.Forms.Label();
            this.lblHotPink = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDefault, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 302);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kattints valamelyik színes téglalapra!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblAquamarine, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblIndigo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblHotPink, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 235);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblAquamarine
            // 
            this.lblAquamarine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAquamarine.BackColor = System.Drawing.Color.Aquamarine;
            this.lblAquamarine.Location = new System.Drawing.Point(83, 13);
            this.lblAquamarine.Name = "lblAquamarine";
            this.lblAquamarine.Size = new System.Drawing.Size(122, 32);
            this.lblAquamarine.TabIndex = 0;
            this.lblAquamarine.Click += new System.EventHandler(this.LblAquamarineClick);
            // 
            // lblLime
            // 
            this.lblLime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLime.BackColor = System.Drawing.Color.Lime;
            this.lblLime.Location = new System.Drawing.Point(83, 71);
            this.lblLime.Name = "lblLime";
            this.lblLime.Size = new System.Drawing.Size(122, 32);
            this.lblLime.TabIndex = 0;
            this.lblLime.Click += new System.EventHandler(this.LblLimeClick);
            // 
            // lblIndigo
            // 
            this.lblIndigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIndigo.BackColor = System.Drawing.Color.Indigo;
            this.lblIndigo.Location = new System.Drawing.Point(83, 129);
            this.lblIndigo.Name = "lblIndigo";
            this.lblIndigo.Size = new System.Drawing.Size(122, 32);
            this.lblIndigo.TabIndex = 0;
            this.lblIndigo.Click += new System.EventHandler(this.LblIndigoClick);
            // 
            // lblHotPink
            // 
            this.lblHotPink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHotPink.BackColor = System.Drawing.Color.HotPink;
            this.lblHotPink.Location = new System.Drawing.Point(83, 188);
            this.lblHotPink.Name = "lblHotPink";
            this.lblHotPink.Size = new System.Drawing.Size(122, 32);
            this.lblHotPink.TabIndex = 0;
            this.lblHotPink.Click += new System.EventHandler(this.LblHotPinkClick);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDefault.Location = new System.Drawing.Point(23, 274);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(100, 25);
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "Alaphelyzet";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefaultClick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(171, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 326);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMain";
            this.Text = "Szinező";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAquamarine;
        private System.Windows.Forms.Label lblLime;
        private System.Windows.Forms.Label lblIndigo;
        private System.Windows.Forms.Label lblHotPink;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnExit;
    }
}

