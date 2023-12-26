namespace GasPipeLine.Windows
{
    partial class WorkingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingWindow));
            this.buttonBegin = new System.Windows.Forms.Button();
            this.buttonGoToMainWindow = new System.Windows.Forms.Button();
            this.buttonCarry = new System.Windows.Forms.Button();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.buttonScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBegin
            // 
            this.buttonBegin.BackColor = System.Drawing.Color.Azure;
            this.buttonBegin.Location = new System.Drawing.Point(673, 519);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(96, 48);
            this.buttonBegin.TabIndex = 1;
            this.buttonBegin.Text = "Начать";
            this.buttonBegin.UseVisualStyleBackColor = false;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // buttonGoToMainWindow
            // 
            this.buttonGoToMainWindow.BackColor = System.Drawing.Color.Azure;
            this.buttonGoToMainWindow.Location = new System.Drawing.Point(38, 519);
            this.buttonGoToMainWindow.Name = "buttonGoToMainWindow";
            this.buttonGoToMainWindow.Size = new System.Drawing.Size(235, 48);
            this.buttonGoToMainWindow.TabIndex = 2;
            this.buttonGoToMainWindow.Text = "Вернуться к главному окну";
            this.buttonGoToMainWindow.UseVisualStyleBackColor = false;
            this.buttonGoToMainWindow.Click += new System.EventHandler(this.buttonGoToMainWindow_Click);
            // 
            // buttonCarry
            // 
            this.buttonCarry.BackColor = System.Drawing.Color.Azure;
            this.buttonCarry.Image = ((System.Drawing.Image)(resources.GetObject("buttonCarry.Image")));
            this.buttonCarry.Location = new System.Drawing.Point(562, 519);
            this.buttonCarry.Name = "buttonCarry";
            this.buttonCarry.Size = new System.Drawing.Size(76, 48);
            this.buttonCarry.TabIndex = 3;
            this.buttonCarry.UseVisualStyleBackColor = false;
            this.buttonCarry.Click += new System.EventHandler(this.buttonCarry_Click);
            // 
            // axMap1
            // 
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(38, 50);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(522, 283);
            this.axMap1.TabIndex = 0;
            // 
            // buttonScreen
            // 
            this.buttonScreen.BackColor = System.Drawing.Color.Azure;
            this.buttonScreen.Location = new System.Drawing.Point(344, 519);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(123, 47);
            this.buttonScreen.TabIndex = 4;
            this.buttonScreen.Text = "Сохранить";
            this.buttonScreen.UseVisualStyleBackColor = false;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // WorkingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 610);
            this.Controls.Add(this.buttonScreen);
            this.Controls.Add(this.buttonCarry);
            this.Controls.Add(this.buttonGoToMainWindow);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.axMap1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочее окно";
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Button buttonGoToMainWindow;
        private System.Windows.Forms.Button buttonCarry;
        private System.Windows.Forms.Button buttonScreen;
    }
}