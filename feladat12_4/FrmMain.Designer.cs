namespace feladat12_4
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnBlueChar = new System.Windows.Forms.Button();
            this.btnWhiteBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLeftCentre = new System.Windows.Forms.Button();
            this.btnCentreCentre = new System.Windows.Forms.Button();
            this.btnRightCentre = new System.Windows.Forms.Button();
            this.btnCapital = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBlueChar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnWhiteBack, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLeftCentre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCentreCentre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRightCentre, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCapital, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnZoomIn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnZoomOut, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDefault, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 258);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblText, 3);
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.Location = new System.Drawing.Point(3, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(327, 116);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Helló világ!";
            // 
            // btnBlueChar
            // 
            this.btnBlueChar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBlueChar.Location = new System.Drawing.Point(5, 119);
            this.btnBlueChar.Name = "btnBlueChar";
            this.btnBlueChar.Size = new System.Drawing.Size(100, 22);
            this.btnBlueChar.TabIndex = 1;
            this.btnBlueChar.Text = "Kék betű";
            this.btnBlueChar.UseVisualStyleBackColor = true;
            this.btnBlueChar.Click += new System.EventHandler(this.BtnBlueCharClick);
            // 
            // btnWhiteBack
            // 
            this.btnWhiteBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWhiteBack.Location = new System.Drawing.Point(116, 119);
            this.btnWhiteBack.Name = "btnWhiteBack";
            this.btnWhiteBack.Size = new System.Drawing.Size(100, 22);
            this.btnWhiteBack.TabIndex = 1;
            this.btnWhiteBack.Text = "Fehér háttér";
            this.btnWhiteBack.UseVisualStyleBackColor = true;
            this.btnWhiteBack.Click += new System.EventHandler(this.BtnWhiteBackClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(227, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 22);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Töröl";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // btnLeftCentre
            // 
            this.btnLeftCentre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeftCentre.Location = new System.Drawing.Point(5, 157);
            this.btnLeftCentre.Name = "btnLeftCentre";
            this.btnLeftCentre.Size = new System.Drawing.Size(100, 22);
            this.btnLeftCentre.TabIndex = 1;
            this.btnLeftCentre.Text = "Balközépre";
            this.btnLeftCentre.UseVisualStyleBackColor = true;
            this.btnLeftCentre.Click += new System.EventHandler(this.BtnLeftCentreClick);
            // 
            // btnCentreCentre
            // 
            this.btnCentreCentre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCentreCentre.Location = new System.Drawing.Point(116, 157);
            this.btnCentreCentre.Name = "btnCentreCentre";
            this.btnCentreCentre.Size = new System.Drawing.Size(100, 22);
            this.btnCentreCentre.TabIndex = 1;
            this.btnCentreCentre.Text = "Közép-középre";
            this.btnCentreCentre.UseVisualStyleBackColor = true;
            this.btnCentreCentre.Click += new System.EventHandler(this.BtnCentreCentreClick);
            // 
            // btnRightCentre
            // 
            this.btnRightCentre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRightCentre.Location = new System.Drawing.Point(227, 157);
            this.btnRightCentre.Name = "btnRightCentre";
            this.btnRightCentre.Size = new System.Drawing.Size(100, 22);
            this.btnRightCentre.TabIndex = 1;
            this.btnRightCentre.Text = "Jobbközépre";
            this.btnRightCentre.UseVisualStyleBackColor = true;
            this.btnRightCentre.Click += new System.EventHandler(this.BtnRightCentreClick);
            // 
            // btnCapital
            // 
            this.btnCapital.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapital.Location = new System.Drawing.Point(5, 195);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(100, 22);
            this.btnCapital.TabIndex = 1;
            this.btnCapital.Text = "Nagybetűs";
            this.btnCapital.UseVisualStyleBackColor = true;
            this.btnCapital.Click += new System.EventHandler(this.BtnCapitalClick);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZoomIn.Location = new System.Drawing.Point(116, 195);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(100, 22);
            this.btnZoomIn.TabIndex = 1;
            this.btnZoomIn.Text = "Nagyít";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.BtnZoomInClick);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZoomOut.Location = new System.Drawing.Point(227, 195);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(100, 22);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "Kicsinyít";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.BtnZoomOutClick);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDefault.Location = new System.Drawing.Point(5, 233);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(100, 22);
            this.btnDefault.TabIndex = 1;
            this.btnDefault.Text = "Alaphelyzet";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefaultClick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.Location = new System.Drawing.Point(227, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 22);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 282);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMain";
            this.Text = "Szöveg formázás";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnBlueChar;
        private System.Windows.Forms.Button btnWhiteBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLeftCentre;
        private System.Windows.Forms.Button btnCentreCentre;
        private System.Windows.Forms.Button btnRightCentre;
        private System.Windows.Forms.Button btnCapital;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnExit;
    }
}

