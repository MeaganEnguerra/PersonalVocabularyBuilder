using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VocabularyCommon;
using PVBBusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using EmailFunc;

namespace PVBDesktop
{
    public partial class GameMode : Form
    {
        private List<SetVocabulary> vocabList = new List<SetVocabulary>();
        private int currentIndex = 0;
        private int correctAnswers = 0;
        private int incorrectAnswers = 0;
        private Random random = new Random();
        private string username;
        private VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
       // private EmailService emailservice = new EmailService();

        public GameMode()
        {
            InitializeComponent();
            LoadVocabulary();
        }

        private void LoadVocabulary()
        {
            string username = Main.userAccount?.Username;
            vocabList = vocabularyBusinessLogic.GetAllWords(username);

            if (vocabList.Count == 0)
            {
                MessageBox.Show("No vocabularies available. Add some words first!", "Info");
                this.Close();
                return;
            }

            ShuffleVocabList();
            ShowNextWord();
        }

        private void ShuffleVocabList()
        {
            vocabList = vocabList.OrderBy(x => random.Next()).ToList();
        }

        private void ShowNextWord()
        {
            if (currentIndex >= vocabList.Count)
            {
                MessageBox.Show("You've reached the end of the word list.", "No More Words", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblGivenMeaning.Text = vocabList[currentIndex].Meaning;
            textBoxGuessWord.Clear();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (currentIndex >= vocabList.Count) return;

            string guess = textBoxGuessWord.Text.Trim();
            string actualWord = vocabList[currentIndex].Word;

            if (guess.Equals(actualWord, StringComparison.OrdinalIgnoreCase))
            {
                correctAnswers++;
                MessageBox.Show("Correct!");
            }
            else
            {
                incorrectAnswers++;
                MessageBox.Show($"Incorrect. The correct word is: {actualWord}");
            }

            currentIndex++;
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex >= vocabList.Count)
            {
                MessageBox.Show("No more words left!");
                return;
            }

            ShowNextWord();
        }

        private void buttonExitgame_Click(object sender, EventArgs e)
        {
            Main main = new Main(username);
            main.Show();
            this.Close();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Scores: \nCorrect answers: {correctAnswers}\nIncorrect answers: {incorrectAnswers}",
               "Score Summary",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            this.Close();

            //emailservice.SendEmail(correctAnswers, incorrectAnswers);
        }
    }
}
