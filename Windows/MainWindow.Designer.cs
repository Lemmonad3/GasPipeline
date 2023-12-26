namespace GasPipeLine.Windows
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonAboutProgramm = new System.Windows.Forms.Button();
            this.AutoButton = new System.Windows.Forms.Button();
            this.buttonEducation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAboutProgramm
            // 
            this.buttonAboutProgramm.BackColor = System.Drawing.Color.Azure;
            this.buttonAboutProgramm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAboutProgramm.Location = new System.Drawing.Point(431, 21);
            this.buttonAboutProgramm.Name = "buttonAboutProgramm";
            this.buttonAboutProgramm.Size = new System.Drawing.Size(126, 47);
            this.buttonAboutProgramm.TabIndex = 0;
            this.buttonAboutProgramm.Text = "О программе";
            this.buttonAboutProgramm.UseVisualStyleBackColor = false;
            this.buttonAboutProgramm.Click += new System.EventHandler(this.buttonAboutProgramm_Click);
            // 
            // AutoButton
            // 
            this.AutoButton.BackColor = System.Drawing.Color.Azure;
            this.AutoButton.Location = new System.Drawing.Point(359, 442);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(157, 43);
            this.AutoButton.TabIndex = 1;
            this.AutoButton.Text = "Авторизоваться";
            this.AutoButton.UseVisualStyleBackColor = false;
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // buttonEducation
            // 
            this.buttonEducation.BackColor = System.Drawing.Color.Azure;
            this.buttonEducation.Location = new System.Drawing.Point(53, 442);
            this.buttonEducation.Name = "buttonEducation";
            this.buttonEducation.Size = new System.Drawing.Size(146, 43);
            this.buttonEducation.TabIndex = 2;
            this.buttonEducation.Text = "Обучение";
            this.buttonEducation.UseVisualStyleBackColor = false;
            this.buttonEducation.Click += new System.EventHandler(this.buttonEducation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Приложение для моделирования GasPipeLine";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEducation);
            this.Controls.Add(this.AutoButton);
            this.Controls.Add(this.buttonAboutProgramm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAboutProgramm;
        private System.Windows.Forms.Button AutoButton;
        private System.Windows.Forms.Button buttonEducation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}