namespace feladat13_08
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
            this.tbxFizetendo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnKave = new System.Windows.Forms.RadioButton();
            this.rbtnKakao = new System.Windows.Forms.RadioButton();
            this.rbtnTea = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbxCukor = new System.Windows.Forms.CheckBox();
            this.chbxCitrom = new System.Windows.Forms.CheckBox();
            this.chbxTej = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fizetendő:";
            // 
            // tbxFizetendo
            // 
            this.tbxFizetendo.Enabled = false;
            this.tbxFizetendo.Location = new System.Drawing.Point(116, 22);
            this.tbxFizetendo.Name = "tbxFizetendo";
            this.tbxFizetendo.Size = new System.Drawing.Size(115, 20);
            this.tbxFizetendo.TabIndex = 1;
            this.tbxFizetendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTea);
            this.groupBox1.Controls.Add(this.rbtnKakao);
            this.groupBox1.Controls.Add(this.rbtnKave);
            this.groupBox1.Location = new System.Drawing.Point(23, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Italok";
            // 
            // rbtnKave
            // 
            this.rbtnKave.AutoSize = true;
            this.rbtnKave.Checked = true;
            this.rbtnKave.Location = new System.Drawing.Point(6, 19);
            this.rbtnKave.Name = "rbtnKave";
            this.rbtnKave.Size = new System.Drawing.Size(50, 17);
            this.rbtnKave.TabIndex = 0;
            this.rbtnKave.TabStop = true;
            this.rbtnKave.Text = "Kávé";
            this.rbtnKave.UseVisualStyleBackColor = true;
            this.rbtnKave.Click += new System.EventHandler(this.ValasztasValtozott);
            // 
            // rbtnKakao
            // 
            this.rbtnKakao.AutoSize = true;
            this.rbtnKakao.Location = new System.Drawing.Point(6, 54);
            this.rbtnKakao.Name = "rbtnKakao";
            this.rbtnKakao.Size = new System.Drawing.Size(56, 17);
            this.rbtnKakao.TabIndex = 0;
            this.rbtnKakao.TabStop = true;
            this.rbtnKakao.Text = "Kakaó";
            this.rbtnKakao.UseVisualStyleBackColor = true;
            this.rbtnKakao.Click += new System.EventHandler(this.ValasztasValtozott);
            // 
            // rbtnTea
            // 
            this.rbtnTea.AutoSize = true;
            this.rbtnTea.Location = new System.Drawing.Point(6, 88);
            this.rbtnTea.Name = "rbtnTea";
            this.rbtnTea.Size = new System.Drawing.Size(44, 17);
            this.rbtnTea.TabIndex = 0;
            this.rbtnTea.TabStop = true;
            this.rbtnTea.Text = "Tea";
            this.rbtnTea.UseVisualStyleBackColor = true;
            this.rbtnTea.Click += new System.EventHandler(this.ValasztasValtozott);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbxTej);
            this.groupBox2.Controls.Add(this.chbxCitrom);
            this.groupBox2.Controls.Add(this.chbxCukor);
            this.groupBox2.Location = new System.Drawing.Point(158, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hozzávalók";
            // 
            // chbxCukor
            // 
            this.chbxCukor.AutoSize = true;
            this.chbxCukor.Location = new System.Drawing.Point(6, 20);
            this.chbxCukor.Name = "chbxCukor";
            this.chbxCukor.Size = new System.Drawing.Size(54, 17);
            this.chbxCukor.TabIndex = 0;
            this.chbxCukor.Text = "Cukor";
            this.chbxCukor.UseVisualStyleBackColor = true;
            this.chbxCukor.Click += new System.EventHandler(this.ValasztasValtozott);
            // 
            // chbxCitrom
            // 
            this.chbxCitrom.AutoSize = true;
            this.chbxCitrom.Enabled = false;
            this.chbxCitrom.Location = new System.Drawing.Point(6, 55);
            this.chbxCitrom.Name = "chbxCitrom";
            this.chbxCitrom.Size = new System.Drawing.Size(55, 17);
            this.chbxCitrom.TabIndex = 0;
            this.chbxCitrom.Text = "Citrom";
            this.chbxCitrom.UseVisualStyleBackColor = true;
            this.chbxCitrom.Click += new System.EventHandler(this.ValasztasValtozott);
            // 
            // chbxTej
            // 
            this.chbxTej.AutoSize = true;
            this.chbxTej.Location = new System.Drawing.Point(6, 90);
            this.chbxTej.Name = "chbxTej";
            this.chbxTej.Size = new System.Drawing.Size(41, 17);
            this.chbxTej.TabIndex = 0;
            this.chbxTej.Text = "Tej";
            this.chbxTej.UseVisualStyleBackColor = true;
            this.chbxTej.Click += new System.EventHandler(this.ValasztasValtozott);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(36, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(209, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 253);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxFizetendo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kávéautomata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFizetendo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTea;
        private System.Windows.Forms.RadioButton rbtnKakao;
        private System.Windows.Forms.RadioButton rbtnKave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbxTej;
        private System.Windows.Forms.CheckBox chbxCitrom;
        private System.Windows.Forms.CheckBox chbxCukor;
        private System.Windows.Forms.Button btnOK;
    }
}

