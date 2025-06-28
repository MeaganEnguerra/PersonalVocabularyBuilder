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
using VocabularyCommon;

namespace PVBDesktop
{
    public partial class ViewAll : Form
    {
        static VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
        private string username;
        public ViewAll(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            LoadVocabularyList();
        }

        private void LoadVocabularyList()
        {
            List<SetVocabulary> vocabList = vocabularyBusinessLogic.GetAllWords(username);

            textBoxViewAll.Clear(); 

            if (vocabList.Count == 0)
            {
                textBoxViewAll.Text = "No words added yet.";
                return;
            }

            foreach (var vocab in vocabList)
            {
                textBoxViewAll.AppendText(
                    $"Word: {vocab.Word}\r\n" +
                    $"Meaning: {vocab.Meaning}\r\n" +
                    $"Sentence: {vocab.Sentence}\r\n\r\n"
                );
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Main main = new Main(username);
            main.Show();
            this.Close();
        }


        private void textBoxViewAll_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
