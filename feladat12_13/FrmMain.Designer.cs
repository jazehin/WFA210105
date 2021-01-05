namespace feladat12_13
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
            this.btnPlayerRock = new System.Windows.Forms.Button();
            this.btnPlayerPaper = new System.Windows.Forms.Button();
            this.btnPlayerScissors = new System.Windows.Forms.Button();
            this.btnCompRock = new System.Windows.Forms.Button();
            this.btnCompPaper = new System.Windows.Forms.Button();
            this.btnCompScissors = new System.Windows.Forms.Button();
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.lblCompPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gép:";
            // 
            // btnPlayerRock
            // 
            this.btnPlayerRock.Location = new System.Drawing.Point(85, 13);
            this.btnPlayerRock.Name = "btnPlayerRock";
            this.btnPlayerRock.Size = new System.Drawing.Size(67, 23);
            this.btnPlayerRock.TabIndex = 1;
            this.btnPlayerRock.Text = "Kő";
            this.btnPlayerRock.UseVisualStyleBackColor = true;
            this.btnPlayerRock.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnPlayerPaper
            // 
            this.btnPlayerPaper.Location = new System.Drawing.Point(169, 13);
            this.btnPlayerPaper.Name = "btnPlayerPaper";
            this.btnPlayerPaper.Size = new System.Drawing.Size(67, 23);
            this.btnPlayerPaper.TabIndex = 2;
            this.btnPlayerPaper.Text = "Papír";
            this.btnPlayerPaper.UseVisualStyleBackColor = true;
            this.btnPlayerPaper.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnPlayerScissors
            // 
            this.btnPlayerScissors.Location = new System.Drawing.Point(251, 13);
            this.btnPlayerScissors.Name = "btnPlayerScissors";
            this.btnPlayerScissors.Size = new System.Drawing.Size(67, 23);
            this.btnPlayerScissors.TabIndex = 3;
            this.btnPlayerScissors.Text = "Olló";
            this.btnPlayerScissors.UseVisualStyleBackColor = true;
            this.btnPlayerScissors.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnCompRock
            // 
            this.btnCompRock.Enabled = false;
            this.btnCompRock.Location = new System.Drawing.Point(85, 51);
            this.btnCompRock.Name = "btnCompRock";
            this.btnCompRock.Size = new System.Drawing.Size(67, 23);
            this.btnCompRock.TabIndex = 1;
            this.btnCompRock.Text = "Kő";
            this.btnCompRock.UseVisualStyleBackColor = true;
            // 
            // btnCompPaper
            // 
            this.btnCompPaper.Enabled = false;
            this.btnCompPaper.Location = new System.Drawing.Point(169, 51);
            this.btnCompPaper.Name = "btnCompPaper";
            this.btnCompPaper.Size = new System.Drawing.Size(67, 23);
            this.btnCompPaper.TabIndex = 2;
            this.btnCompPaper.Text = "Papír";
            this.btnCompPaper.UseVisualStyleBackColor = true;
            // 
            // btnCompScissors
            // 
            this.btnCompScissors.Enabled = false;
            this.btnCompScissors.Location = new System.Drawing.Point(251, 51);
            this.btnCompScissors.Name = "btnCompScissors";
            this.btnCompScissors.Size = new System.Drawing.Size(67, 23);
            this.btnCompScissors.TabIndex = 3;
            this.btnCompScissors.Text = "Olló";
            this.btnCompScissors.UseVisualStyleBackColor = true;
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.Location = new System.Drawing.Point(342, 18);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(37, 13);
            this.lblPlayerPoints.TabIndex = 0;
            this.lblPlayerPoints.Text = "0 pont";
            // 
            // lblCompPoints
            // 
            this.lblCompPoints.AutoSize = true;
            this.lblCompPoints.Location = new System.Drawing.Point(342, 56);
            this.lblCompPoints.Name = "lblCompPoints";
            this.lblCompPoints.Size = new System.Drawing.Size(37, 13);
            this.lblCompPoints.TabIndex = 0;
            this.lblCompPoints.Text = "0 pont";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 90);
            this.Controls.Add(this.btnCompScissors);
            this.Controls.Add(this.btnPlayerScissors);
            this.Controls.Add(this.btnCompPaper);
            this.Controls.Add(this.btnPlayerPaper);
            this.Controls.Add(this.btnCompRock);
            this.Controls.Add(this.btnPlayerRock);
            this.Controls.Add(this.lblCompPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerPoints);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kő-papír-olló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayerRock;
        private System.Windows.Forms.Button btnPlayerPaper;
        private System.Windows.Forms.Button btnPlayerScissors;
        private System.Windows.Forms.Button btnCompRock;
        private System.Windows.Forms.Button btnCompPaper;
        private System.Windows.Forms.Button btnCompScissors;
        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Label lblCompPoints;
    }
}

