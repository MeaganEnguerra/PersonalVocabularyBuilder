namespace PVBDesktop
{
    public partial class Welcome : Form
    {

        public Welcome()
        {
            InitializeComponent();
        }

        private void lblGetStarted_Click(object sender, EventArgs e)
        {
            Login_Signup login_Signup = new Login_Signup();
            login_Signup.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnWhatisVocaBee_Click(object sender, EventArgs e)
        {
            whatIsVocabee whatIsVocabee = new whatIsVocabee();
            whatIsVocabee.Show();
            this.Hide();
        }
    }
}
