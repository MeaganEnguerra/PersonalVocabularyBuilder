using PVBBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VocabularyCommon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PVBDesktop
{
    public partial class Main : Form
    {
        static VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
        static bool loggedIn = false;
        public static UserAccount userAccount;
        private string username;


        public Main(string username)
        {
            InitializeComponent();
            this.username = username;

            lblUser1.Text = this.username;
            lblUser2.Text = this.username;
            lblUser3.Text = this.username;
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void btnArrowDown_Click(object sender, EventArgs e)
        {
            panelAccountSetting.Visible = !panelAccountSetting.Visible;

            if (panelAccountSetting.Visible)
            {
                panelAccountSetting.BringToFront();
            }
        }

        private void lblword4_Click(object sender, EventArgs e)
        {

        }

        private void lblWord1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;
        }

        private void LoadVocabularyList()
        {
            string username = Main.userAccount?.Username;
            List<SetVocabulary> vocabList = vocabularyBusinessLogic.GetAllWords(username);

            lblWord1.Text = lblMeaning1.Text = lblSentence1.Text = "";
            lblword2.Text = lblmeaning2.Text = lblSentence2.Text = "";


            if (vocabList.Count > 0)
            {
                lblWord1.Text = vocabList[0].Word;
                lblMeaning1.Text = vocabList[0].Meaning;
                lblSentence1.Text = vocabList[0].Sentence;
            }

            if (vocabList.Count > 1)
            {
                lblword2.Text = vocabList[1].Word;
                lblmeaning2.Text = vocabList[1].Meaning;
                lblSentence2.Text = vocabList[1].Sentence;
            }

            if (vocabList.Count == 0)
            {
                lblTotalWords.Text = "No words saved yet.";
            }
            lblTotalWords.Text = $"{vocabList.Count}";
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            {
                string word = textBoxWord.Text.Trim();
                string meaning = textBoxMeaning.Text.Trim();
                string sentence = textBoxSentence.Text.Trim();
                string username = userAccount?.Username;

                if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(meaning))
                {
                    MessageBox.Show("Please enter both a word and its meaning.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                vocabularyBusinessLogic.AddWord(word, meaning, sentence, username);
                MessageBox.Show($"'{word}' has been added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxWord.Clear();
                textBoxMeaning.Clear();
                textBoxSentence.Clear();
            }
            LoadVocabularyList();
        }

        private void btnViewVocabularies_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = true;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;

            panelViewVocabularies.BringToFront();
        }

        private void panelAccountSetting_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login_Signup login_Signup = new Login_Signup();
            login_Signup.Show();
            this.Close();
        }


        private void btntrash_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = true;
            panelSearchResult.Visible = false;

            panelDeleteAccount.BringToFront();
        }

        private void panelDeleteAccount_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblAddWord_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = true;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;

            panelAddWord.BringToFront();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userAccount == null)
                userAccount = LogIn.userAccount;

            string inputUsername = txtboxUsername.Text.Trim();
            string inputPassword = txtboxpassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool deleted = vocabularyBusinessLogic.DeleteAccount(inputUsername, inputPassword);

                if (deleted)
                {
                    MessageBox.Show("Account has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loggedIn = false;
                    userAccount = null;

                    Login_Signup loginForm = new Login_Signup();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtbxSearch.Text.Trim();
            string userName = Main.userAccount?.Username;

            var wordEntry = vocabularyBusinessLogic.SearchWord(searchWord, userName);

            if (wordEntry == null)
            {
                MessageBox.Show(searchWord + " is not in your vocabulary list.", "Word Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxSearch.Clear();
                return;
            }

            panelSearchResult.Visible = true;
            panelSearchResult.BringToFront();

            lblResultWord.Text = wordEntry.Word;
            lblResultMeaning.Text = wordEntry.Meaning;
            lblResultSentence.Text = wordEntry.Sentence;
            txtbxSearch.Clear();
        }

        private void panelSearchResult_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            panelSearchResult.Visible = false;
        }

        private void lblResultWord_Click(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadVocabularyList();
        }

        private void btnDeleteWord1_Click(object sender, EventArgs e)
        {

            string username = Main.userAccount?.Username;
            string wordToDelete = lblWord1.Text;

            bool success = vocabularyBusinessLogic.RemoveWord(wordToDelete, username);

            if (success)
            {
                MessageBox.Show("Word deleted successfully.");
                LoadVocabularyList();
            }
            else
            {
                MessageBox.Show("Failed to delete the word.");
            }
        }

        private void btnDeleteWord2_Click(object sender, EventArgs e)
        {
            string username = Main.userAccount?.Username;
            string wordToDelete = lblword2.Text;

            bool success = vocabularyBusinessLogic.RemoveWord(wordToDelete, username);

            if (success)
            {
                MessageBox.Show("Word deleted successfully.");
                LoadVocabularyList();
            }
            else
            {
                MessageBox.Show("Failed to delete the word.");
            }
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {

            string username = Main.userAccount?.Username;

            string oldWord = lblWord1.Text.Trim();

            string newWord = textBoxNewWord.Text.Trim();
            string newMeaning = textBoxNewMeaning.Text.Trim();
            string newSentence = textBoxNewSentence.Text.Trim();

            bool success = vocabularyBusinessLogic.UpdateWord(oldWord, newWord, newMeaning, newSentence, username);

            if (success)
            {
                MessageBox.Show("Updated successfully!");
                LoadVocabularyList();
                textBoxNewWord.Clear();
                textBoxNewMeaning.Clear();
                textBoxNewSentence.Clear();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void btnAddWord1_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;
            panelUpdateWord.Visible = true;

            panelUpdateWord.BringToFront();
        }
        private void btnAddWord2_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;
            panelUpdateWord.Visible = true;

            panelUpdateWord.BringToFront();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;
            panelUpdateWord.Visible = false;
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            string username = Main.userAccount?.Username;
            ViewAll viewAll = new ViewAll(username);
            viewAll.Show();
        }

        private void btnAddWord2_Click_1(object sender, EventArgs e)
        {
            panelViewVocabularies.Visible = false;
            panelAddWord.Visible = false;
            panelDeleteAccount.Visible = false;
            panelSearchResult.Visible = false;
            panelUpdateWord.Visible = true;

            panelUpdateWord.BringToFront();
        }

        private void lblGameMode_Click(object sender, EventArgs e)
        {
            GameMode game = new GameMode();
            game.Show();
            this.Hide();
        }
    }
}

