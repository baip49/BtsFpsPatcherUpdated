namespace BtsFpsPatcher
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GameExecutableLabel = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.PatchButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.FPSLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PatchWorker = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.TitleLabel.Location = new System.Drawing.Point(27, 10);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(372, 18);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Beyond Two Souls FPS Patcher by PhantomGamers";
            // 
            // GameExecutableLabel
            // 
            this.GameExecutableLabel.AutoSize = true;
            this.GameExecutableLabel.Location = new System.Drawing.Point(27, 58);
            this.GameExecutableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameExecutableLabel.Name = "GameExecutableLabel";
            this.GameExecutableLabel.Size = new System.Drawing.Size(122, 15);
            this.GameExecutableLabel.TabIndex = 2;
            this.GameExecutableLabel.Text = "Ejecutable del juego:";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(147, 54);
            this.PathBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(200, 21);
            this.PathBox.TabIndex = 3;
            this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(355, 51);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(88, 27);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Examinar";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // PatchButton
            // 
            this.PatchButton.Enabled = false;
            this.PatchButton.Location = new System.Drawing.Point(449, 51);
            this.PatchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PatchButton.Name = "PatchButton";
            this.PatchButton.Size = new System.Drawing.Size(88, 27);
            this.PatchButton.TabIndex = 5;
            this.PatchButton.Text = "Ejecutar";
            this.PatchButton.UseVisualStyleBackColor = true;
            this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatusLabel.Location = new System.Drawing.Point(29, 135);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 15);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Estatus:";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.ForeColor = System.Drawing.Color.Blue;
            this.StatusText.Location = new System.Drawing.Point(84, 135);
            this.StatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(77, 15);
            this.StatusText.TabIndex = 7;
            this.StatusText.Text = "Esperando...";
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Location = new System.Drawing.Point(28, 87);
            this.FPSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(96, 15);
            this.FPSLabel.TabIndex = 8;
            this.FPSLabel.Text = "FPS requeridos:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 153);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(497, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // PatchWorker
            // 
            this.PatchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PatchWorker_DoWork);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(147, 84);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 21);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Set to 0 for no limit";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(29, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(223, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Modificado por Baip | usecodebaip.com";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 208);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FPSLabel);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PatchButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.GameExecutableLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Beyond Two Souls FPS Patcher v1.2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label GameExecutableLabel;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button PatchButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label FPSLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker PatchWorker;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

