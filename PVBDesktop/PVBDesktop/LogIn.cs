using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVBBusinessLogic;
using VocabularyCommon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PVBDesktop
{
    public partial class LogIn : Form
    {
        static VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
        static bool loggedIn = false;
        public static UserAccount userAccount;

        public LogIn()
        {
            InitializeComponent();
           
        }      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            string userName = txtboxUsername.Text.Trim();
            string passWord = txtboxPassword.Text.Trim();

            var account = vocabularyBusinessLogic.GetAccount(userName, passWord);
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            
            if (vocabularyBusinessLogic.ValidateVocabularyAccount(userName, passWord))
            {
                loggedIn = true;
                userAccount = account;
                MessageBox.Show("Login successful! Welcome, " + userName + "!");
                Main.userAccount = userAccount;
                Main dashboard = new Main(userName);
                dashboard.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.");
            }

           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login_Signup login_Signup = new Login_Signup();
            login_Signup.Show();
            this.Close();
        }
    }
}
