using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using PVBBusinessLogic;
using VocabularyCommon;

namespace PVBDesktop
{
    public partial class SignUp : Form
    {

        VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
        public SignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login_Signup login_Signup = new Login_Signup();
            login_Signup.Show();
            this.Close();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string passWord = txtPassword.Text.Trim();

        
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Please input your Username and Password.");
                return; 
            }

            
            if (vocabularyBusinessLogic.ExistedAccounts(userName))
            {
                MessageBox.Show("That username is already taken. Try logging in or use another username.");
                return;
            }

        
            vocabularyBusinessLogic.CreateAccount(userName, passWord);
            MessageBox.Show("Sign up successful! You can now log in with your new account.");

            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

    }
}
