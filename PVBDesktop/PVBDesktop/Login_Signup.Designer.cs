namespace PVBDesktop
{
    partial class Login_Signup
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
            lblLogIn = new Label();
            lblSignUp = new Label();
            lblExit = new Label();
            SuspendLayout();
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.BackColor = Color.FromArgb(133, 72, 54);
            lblLogIn.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogIn.ForeColor = Color.FromArgb(255, 233, 154);
            lblLogIn.Location = new Point(192, 320);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(93, 32);
            lblLogIn.TabIndex = 0;
            lblLogIn.Text = "Log In";
            lblLogIn.Click += lblLogIn_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.BackColor = Color.FromArgb(254, 207, 103);
            lblSignUp.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.Location = new Point(182, 390);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(112, 32);
            lblSignUp.TabIndex = 1;
            lblSignUp.Text = "Sign Up";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.FromArgb(255, 233, 154);
            lblExit.Location = new Point(211, 495);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(52, 30);
            lblExit.TabIndex = 2;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // Login_Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.signupLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 565);
            Controls.Add(lblExit);
            Controls.Add(lblSignUp);
            Controls.Add(lblLogIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogIn;
        private Label lblSignUp;
        private Label lblExit;
    }
}