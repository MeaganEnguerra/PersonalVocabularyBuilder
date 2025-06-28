namespace PVBDesktop
{
    partial class SignUp
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
            lblSignUp = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblSignUp);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(204, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 311);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = Color.FromArgb(133, 72, 54);
            lblSignUp.Location = new Point(203, 239);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(209, 56);
            lblSignUp.TabIndex = 3;
            lblSignUp.Text = "SIGN UP";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 233, 154);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(133, 72, 54);
            txtPassword.Location = new Point(151, 155);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Create your secret buzzword...";
            txtPassword.Size = new Size(317, 26);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 233, 154);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(133, 72, 54);
            txtUsername.Location = new Point(151, 81);
            txtUsername.Margin = new Padding(0);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Create your hive name...";
            txtUsername.Size = new Size(333, 26);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 178, 44);
            label1.Location = new Point(242, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.x_icon;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(928, 21);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 32);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f_log_in_w_exit;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 565);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUsername;
        private Label lblSignUp;
        private TextBox txtPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnExit;
    }
}