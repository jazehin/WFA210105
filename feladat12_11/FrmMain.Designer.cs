﻿namespace feladat12_11
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.lbxData = new System.Windows.Forms.ListBox();
            this.btnAvg = new System.Windows.Forms.Button();
            this.lblAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pontszám:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adatbevitel";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(80, 9);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(156, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxPoints
            // 
            this.tbxPoints.Location = new System.Drawing.Point(80, 38);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(156, 20);
            this.tbxPoints.TabIndex = 3;
            // 
            // lbxData
            // 
            this.lbxData.FormattingEnabled = true;
            this.lbxData.Location = new System.Drawing.Point(15, 121);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(221, 134);
            this.lbxData.TabIndex = 4;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(15, 276);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(148, 23);
            this.btnAvg.TabIndex = 1;
            this.btnAvg.Text = "Átlagpontszám";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.BtnAvgClick);
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAvg.Location = new System.Drawing.Point(169, 281);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(0, 13);
            this.lblAvg.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 314);
            this.Controls.Add(this.lbxData);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Dolgozat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPoints;
        private System.Windows.Forms.ListBox lbxData;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Label lblAvg;
    }
}

