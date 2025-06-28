namespace PVBDesktop
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGetStarted = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblGetStarted
            // 
            lblGetStarted.AutoSize = true;
            lblGetStarted.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetStarted.Location = new Point(415, 456);
            lblGetStarted.Name = "lblGetStarted";
            lblGetStarted.Size = new Size(170, 32);
            lblGetStarted.TabIndex = 0;
            lblGetStarted.Text = "Get Started!";
            lblGetStarted.Click += lblGetStarted_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 214, 107);
            label3.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(133, 72, 54);
            label3.Location = new Point(427, 519);
            label3.Name = "label3";
            label3.Size = new Size(158, 19);
            label3.TabIndex = 1;
            label3.Text = "What is VocaBee?";
            label3.Click += btnWhatisVocaBee_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.x_icon;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(934, 22);
            button1.Name = "button1";
            button1.Size = new Size(39, 27);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(133, 72, 54);
            BackgroundImage = Properties.Resources._1st;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 565);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lblGetStarted);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 178, 44);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblGetStarted;
        private Label label3;
        private Button button1;
    }
}
