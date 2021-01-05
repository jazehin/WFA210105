namespace feladat12_15
{
    partial class Form1
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
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnDisappear = new System.Windows.Forms.Button();
            this.btnReappear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::feladat12_15.Properties.Resources.smiley;
            this.pbxImage.Location = new System.Drawing.Point(152, 100);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(120, 120);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            this.pbxImage.Click += new System.EventHandler(this.ImageChangePos);
            this.pbxImage.MouseEnter += new System.EventHandler(this.ImageWink);
            this.pbxImage.MouseLeave += new System.EventHandler(this.ImageSmiley);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mi a kedvenc szavad?";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(56, 38);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(315, 20);
            this.tbxInput.TabIndex = 2;
            this.tbxInput.TextChanged += new System.EventHandler(this.TbxInputTextChanged);
            // 
            // btnDisappear
            // 
            this.btnDisappear.Location = new System.Drawing.Point(56, 250);
            this.btnDisappear.Name = "btnDisappear";
            this.btnDisappear.Size = new System.Drawing.Size(99, 36);
            this.btnDisappear.TabIndex = 3;
            this.btnDisappear.Text = "Tűnj el!";
            this.btnDisappear.UseVisualStyleBackColor = true;
            this.btnDisappear.Click += new System.EventHandler(this.BtnDisappearClick);
            // 
            // btnReappear
            // 
            this.btnReappear.Enabled = false;
            this.btnReappear.Location = new System.Drawing.Point(272, 250);
            this.btnReappear.Name = "btnReappear";
            this.btnReappear.Size = new System.Drawing.Size(99, 36);
            this.btnReappear.TabIndex = 3;
            this.btnReappear.Text = "Gyere vissza!";
            this.btnReappear.UseVisualStyleBackColor = true;
            this.btnReappear.Click += new System.EventHandler(this.BtnReappearClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 309);
            this.Controls.Add(this.btnReappear);
            this.Controls.Add(this.btnDisappear);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxImage);
            this.Name = "Form1";
            this.Text = "Vizuális eseményvezérelt programozás";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnDisappear;
        private System.Windows.Forms.Button btnReappear;
    }
}

