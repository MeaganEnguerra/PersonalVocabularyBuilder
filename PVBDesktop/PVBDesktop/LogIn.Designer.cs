namespace PVBDesktop
{
    partial class LogIn
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
            panel1 = new Panel();
            label1 = new Label();
            txtboxPassword = new TextBox();
            txtboxUsername = new TextBox();
            lblLogIn = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtboxPassword);
            panel1.Controls.Add(txtboxUsername);
            panel1.Location = new Point(200, 265);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 249);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 72, 54);
            label1.Location = new Point(215, 183);
            label1.Name = "label1";
            label1.Size = new Size(187, 56);
            label1.TabIndex = 2;
            label1.Text = "LOG IN";
            label1.Click += btnLogIn_Click_1;
            // 
            // txtboxPassword
            // 
            txtboxPassword.BackColor = Color.FromArgb(255, 233, 154);
            txtboxPassword.BorderStyle = BorderStyle.None;
            txtboxPassword.Font = new Font("Century Gothic", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtboxPassword.ForeColor = Color.FromArgb(133, 72, 54);
            txtboxPassword.Location = new Point(160, 101);
            txtboxPassword.Margin = new Padding(0);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PlaceholderText = "Enter your secret buzzword...";
            txtboxPassword.Size = new Size(293, 25);
            txtboxPassword.TabIndex = 1;
            txtboxPassword.TabStop = false;
            // 
            // txtboxUsername
            // 
            txtboxUsername.BackColor = Color.FromArgb(255, 233, 154);
            txtboxUsername.BorderStyle = BorderStyle.None;
            txtboxUsername.Font = new Font("Century Gothic", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtboxUsername.ForeColor = Color.FromArgb(133, 72, 54);
            txtboxUsername.Location = new Point(160, 29);
            txtboxUsername.Margin = new Padding(0);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.PlaceholderText = "Enter your hive name...";
            txtboxUsername.Size = new Size(226, 25);
            txtboxUsername.TabIndex = 0;
            txtboxUsername.TabStop = false;
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.BackColor = Color.FromArgb(133, 72, 54);
            lblLogIn.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogIn.ForeColor = Color.FromArgb(255, 178, 44);
            lblLogIn.Location = new Point(457, 205);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(109, 38);
            lblLogIn.TabIndex = 1;
            lblLogIn.Text = "Log In";
            lblLogIn.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.x_icon;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(930, 23);
            button1.Name = "button1";
            button1.Size = new Size(45, 30);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f_log_in_w_exit;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 565);
            Controls.Add(button1);
            Controls.Add(lblLogIn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblLogIn;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Label label1;
        private Button button1;
    }
}