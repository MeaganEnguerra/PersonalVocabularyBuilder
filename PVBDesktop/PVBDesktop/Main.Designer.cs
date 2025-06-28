namespace PVBDesktop
{
    partial class Main
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
            btnArrowDown = new Button();
            lblUser1 = new Label();
            txtbxSearch = new TextBox();
            btnSearch = new Button();
            btnViewVocabularies = new Label();
            lblAddWord = new Label();
            lblGameMode = new Label();
            lblUser2 = new Label();
            lblTotalWords = new Label();
            btnSeeAll = new Button();
            lblUser3 = new Label();
            lblWord1 = new Label();
            label1 = new Label();
            panelViewVocabularies = new Panel();
            btnDeleteWord2 = new Button();
            btnDeleteWord1 = new Button();
            btnAddWord2 = new Button();
            btnAddWord1 = new Button();
            lblSentence2 = new Label();
            lblSentence1 = new Label();
            lblmeaning2 = new Label();
            lblMeaning1 = new Label();
            lblword2 = new Label();
            panelAddWord = new Panel();
            btnX = new Button();
            btnConfirm = new Button();
            textBoxSentence = new TextBox();
            textBoxMeaning = new TextBox();
            textBoxWord = new TextBox();
            panelDeleteAccount = new Panel();
            btnCancel = new Label();
            btnDelete = new Label();
            txtboxpassword = new TextBox();
            txtboxUsername = new TextBox();
            panelAccountSetting = new Panel();
            btntrash = new Label();
            btnLogOut = new Label();
            panelSearchResult = new Panel();
            btnSearchBack = new Button();
            lblResultSentence = new Label();
            lblResultMeaning = new Label();
            lblResultWord = new Label();
            btnRefresh = new Label();
            panelUpdateWord = new Panel();
            btnConfirmUpdate = new Button();
            btnCancelUpdate = new Button();
            textBoxNewSentence = new TextBox();
            textBoxNewMeaning = new TextBox();
            textBoxNewWord = new TextBox();
            panelViewVocabularies.SuspendLayout();
            panelAddWord.SuspendLayout();
            panelDeleteAccount.SuspendLayout();
            panelAccountSetting.SuspendLayout();
            panelSearchResult.SuspendLayout();
            panelUpdateWord.SuspendLayout();
            SuspendLayout();
            // 
            // btnArrowDown
            // 
            btnArrowDown.BackgroundImage = Properties.Resources.ARROWDOWN;
            btnArrowDown.BackgroundImageLayout = ImageLayout.Stretch;
            btnArrowDown.FlatAppearance.BorderSize = 0;
            btnArrowDown.FlatStyle = FlatStyle.Flat;
            btnArrowDown.Location = new Point(12, 12);
            btnArrowDown.Name = "btnArrowDown";
            btnArrowDown.Size = new Size(26, 23);
            btnArrowDown.TabIndex = 0;
            btnArrowDown.UseVisualStyleBackColor = true;
            btnArrowDown.Click += btnArrowDown_Click;
            // 
            // lblUser1
            // 
            lblUser1.AutoSize = true;
            lblUser1.BackColor = Color.FromArgb(138, 104, 81);
            lblUser1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser1.ForeColor = Color.FromArgb(255, 214, 107);
            lblUser1.Location = new Point(87, 15);
            lblUser1.Name = "lblUser1";
            lblUser1.Size = new Size(65, 16);
            lblUser1.TabIndex = 1;
            lblUser1.Text = "@user123";
            // 
            // txtbxSearch
            // 
            txtbxSearch.BackColor = SystemColors.Window;
            txtbxSearch.BorderStyle = BorderStyle.None;
            txtbxSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxSearch.Location = new Point(59, 127);
            txtbxSearch.Name = "txtbxSearch";
            txtbxSearch.PlaceholderText = "Search saved words...";
            txtbxSearch.Size = new Size(138, 16);
            txtbxSearch.TabIndex = 2;
            txtbxSearch.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 214, 107);
            btnSearch.BackgroundImage = Properties.Resources.SEARCHBUTTON;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(230, 127);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(22, 19);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewVocabularies
            // 
            btnViewVocabularies.AutoSize = true;
            btnViewVocabularies.BackColor = Color.FromArgb(255, 214, 107);
            btnViewVocabularies.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewVocabularies.ForeColor = Color.FromArgb(133, 72, 54);
            btnViewVocabularies.Location = new Point(46, 193);
            btnViewVocabularies.Name = "btnViewVocabularies";
            btnViewVocabularies.Size = new Size(183, 23);
            btnViewVocabularies.TabIndex = 4;
            btnViewVocabularies.Text = "View Vocabularies";
            btnViewVocabularies.Click += btnViewVocabularies_Click;
            // 
            // lblAddWord
            // 
            lblAddWord.AutoSize = true;
            lblAddWord.BackColor = Color.FromArgb(255, 214, 107);
            lblAddWord.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWord.ForeColor = Color.FromArgb(133, 72, 54);
            lblAddWord.Location = new Point(87, 252);
            lblAddWord.Name = "lblAddWord";
            lblAddWord.Size = new Size(103, 23);
            lblAddWord.TabIndex = 5;
            lblAddWord.Text = "Add Word";
            lblAddWord.Click += lblAddWord_Click;
            // 
            // lblGameMode
            // 
            lblGameMode.AutoSize = true;
            lblGameMode.BackColor = Color.FromArgb(225, 239, 232);
            lblGameMode.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameMode.ForeColor = Color.FromArgb(133, 72, 54);
            lblGameMode.Location = new Point(46, 358);
            lblGameMode.Name = "lblGameMode";
            lblGameMode.Size = new Size(183, 23);
            lblGameMode.TabIndex = 6;
            lblGameMode.Text = "Enter Game Mode!";
            // 
            // lblUser2
            // 
            lblUser2.AutoSize = true;
            lblUser2.BackColor = Color.FromArgb(133, 72, 54);
            lblUser2.ForeColor = SystemColors.ButtonHighlight;
            lblUser2.Location = new Point(171, 444);
            lblUser2.Name = "lblUser2";
            lblUser2.Size = new Size(58, 15);
            lblUser2.TabIndex = 7;
            lblUser2.Text = "@user123";
            // 
            // lblTotalWords
            // 
            lblTotalWords.AutoSize = true;
            lblTotalWords.BackColor = Color.FromArgb(133, 72, 54);
            lblTotalWords.ForeColor = SystemColors.ButtonHighlight;
            lblTotalWords.Location = new Point(139, 473);
            lblTotalWords.Name = "lblTotalWords";
            lblTotalWords.Size = new Size(13, 15);
            lblTotalWords.TabIndex = 8;
            lblTotalWords.Text = "0";
            // 
            // btnSeeAll
            // 
            btnSeeAll.BackgroundImage = Properties.Resources.down;
            btnSeeAll.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeeAll.FlatAppearance.BorderSize = 0;
            btnSeeAll.FlatStyle = FlatStyle.Flat;
            btnSeeAll.Location = new Point(553, 181);
            btnSeeAll.Name = "btnSeeAll";
            btnSeeAll.Size = new Size(35, 20);
            btnSeeAll.TabIndex = 1;
            btnSeeAll.UseVisualStyleBackColor = true;
            btnSeeAll.Click += btnSeeAll_Click;
            // 
            // lblUser3
            // 
            lblUser3.AutoSize = true;
            lblUser3.BackColor = Color.FromArgb(255, 233, 154);
            lblUser3.FlatStyle = FlatStyle.Flat;
            lblUser3.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUser3.Location = new Point(465, 42);
            lblUser3.Name = "lblUser3";
            lblUser3.Size = new Size(142, 36);
            lblUser3.TabIndex = 0;
            lblUser3.Text = "@user123";
            // 
            // lblWord1
            // 
            lblWord1.BackColor = Color.FromArgb(225, 239, 232);
            lblWord1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWord1.Location = new Point(54, 263);
            lblWord1.Name = "lblWord1";
            lblWord1.Size = new Size(223, 45);
            lblWord1.TabIndex = 3;
            lblWord1.Text = "Word here...";
            lblWord1.Click += lblWord1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(225, 239, 232);
            label1.Location = new Point(73, 343);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 9;
            // 
            // panelViewVocabularies
            // 
            panelViewVocabularies.BackgroundImage = Properties.Resources.view;
            panelViewVocabularies.BackgroundImageLayout = ImageLayout.Stretch;
            panelViewVocabularies.Controls.Add(btnDeleteWord2);
            panelViewVocabularies.Controls.Add(btnDeleteWord1);
            panelViewVocabularies.Controls.Add(btnAddWord2);
            panelViewVocabularies.Controls.Add(btnAddWord1);
            panelViewVocabularies.Controls.Add(lblSentence2);
            panelViewVocabularies.Controls.Add(lblSentence1);
            panelViewVocabularies.Controls.Add(lblmeaning2);
            panelViewVocabularies.Controls.Add(lblMeaning1);
            panelViewVocabularies.Controls.Add(lblword2);
            panelViewVocabularies.Controls.Add(label1);
            panelViewVocabularies.Controls.Add(lblWord1);
            panelViewVocabularies.Controls.Add(lblUser3);
            panelViewVocabularies.Controls.Add(btnSeeAll);
            panelViewVocabularies.Location = new Point(326, 12);
            panelViewVocabularies.Name = "panelViewVocabularies";
            panelViewVocabularies.Size = new Size(675, 525);
            panelViewVocabularies.TabIndex = 9;
            panelViewVocabularies.Visible = false;
            // 
            // btnDeleteWord2
            // 
            btnDeleteWord2.BackgroundImage = Properties.Resources.TRASH;
            btnDeleteWord2.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteWord2.FlatAppearance.BorderSize = 0;
            btnDeleteWord2.FlatStyle = FlatStyle.Flat;
            btnDeleteWord2.Location = new Point(566, 433);
            btnDeleteWord2.Name = "btnDeleteWord2";
            btnDeleteWord2.Size = new Size(34, 25);
            btnDeleteWord2.TabIndex = 18;
            btnDeleteWord2.UseVisualStyleBackColor = true;
            btnDeleteWord2.Click += btnDeleteWord2_Click;
            // 
            // btnDeleteWord1
            // 
            btnDeleteWord1.BackgroundImage = Properties.Resources.TRASH;
            btnDeleteWord1.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteWord1.FlatAppearance.BorderSize = 0;
            btnDeleteWord1.FlatStyle = FlatStyle.Flat;
            btnDeleteWord1.Location = new Point(274, 433);
            btnDeleteWord1.Name = "btnDeleteWord1";
            btnDeleteWord1.Size = new Size(34, 25);
            btnDeleteWord1.TabIndex = 17;
            btnDeleteWord1.UseVisualStyleBackColor = true;
            btnDeleteWord1.Click += btnDeleteWord1_Click;
            // 
            // btnAddWord2
            // 
            btnAddWord2.BackgroundImage = Properties.Resources.PEN;
            btnAddWord2.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddWord2.FlatAppearance.BorderSize = 0;
            btnAddWord2.FlatStyle = FlatStyle.Flat;
            btnAddWord2.Location = new Point(526, 433);
            btnAddWord2.Name = "btnAddWord2";
            btnAddWord2.Size = new Size(34, 25);
            btnAddWord2.TabIndex = 16;
            btnAddWord2.UseVisualStyleBackColor = true;
            btnAddWord2.Click += btnAddWord2_Click_1;
            // 
            // btnAddWord1
            // 
            btnAddWord1.BackgroundImage = Properties.Resources.PEN;
            btnAddWord1.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddWord1.FlatAppearance.BorderSize = 0;
            btnAddWord1.FlatStyle = FlatStyle.Flat;
            btnAddWord1.Location = new Point(234, 433);
            btnAddWord1.Name = "btnAddWord1";
            btnAddWord1.Size = new Size(34, 25);
            btnAddWord1.TabIndex = 15;
            btnAddWord1.UseVisualStyleBackColor = true;
            btnAddWord1.Click += btnAddWord1_Click;
            // 
            // lblSentence2
            // 
            lblSentence2.BackColor = Color.FromArgb(225, 239, 232);
            lblSentence2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSentence2.Location = new Point(357, 383);
            lblSentence2.Name = "lblSentence2";
            lblSentence2.Size = new Size(243, 64);
            lblSentence2.TabIndex = 14;
            lblSentence2.Text = "Example here...";
            // 
            // lblSentence1
            // 
            lblSentence1.BackColor = Color.FromArgb(225, 239, 232);
            lblSentence1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSentence1.Location = new Point(54, 383);
            lblSentence1.Name = "lblSentence1";
            lblSentence1.Size = new Size(254, 47);
            lblSentence1.TabIndex = 13;
            lblSentence1.Text = "Example here...";
            // 
            // lblmeaning2
            // 
            lblmeaning2.BackColor = Color.FromArgb(225, 239, 232);
            lblmeaning2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmeaning2.Location = new Point(356, 313);
            lblmeaning2.Name = "lblmeaning2";
            lblmeaning2.Size = new Size(244, 59);
            lblmeaning2.TabIndex = 12;
            lblmeaning2.Text = "Meaning here...";
            // 
            // lblMeaning1
            // 
            lblMeaning1.BackColor = Color.FromArgb(225, 239, 232);
            lblMeaning1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeaning1.Location = new Point(54, 313);
            lblMeaning1.Name = "lblMeaning1";
            lblMeaning1.Size = new Size(254, 59);
            lblMeaning1.TabIndex = 11;
            lblMeaning1.Text = "Meaning here...";
            // 
            // lblword2
            // 
            lblword2.AutoSize = true;
            lblword2.BackColor = Color.FromArgb(225, 239, 232);
            lblword2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblword2.Location = new Point(357, 263);
            lblword2.Name = "lblword2";
            lblword2.Size = new Size(100, 19);
            lblword2.TabIndex = 10;
            lblword2.Text = "Word here...";
            // 
            // panelAddWord
            // 
            panelAddWord.BackgroundImage = Properties.Resources.panelAddword;
            panelAddWord.BackgroundImageLayout = ImageLayout.Stretch;
            panelAddWord.Controls.Add(btnX);
            panelAddWord.Controls.Add(btnConfirm);
            panelAddWord.Controls.Add(textBoxSentence);
            panelAddWord.Controls.Add(textBoxMeaning);
            panelAddWord.Controls.Add(textBoxWord);
            panelAddWord.Location = new Point(282, 70);
            panelAddWord.Name = "panelAddWord";
            panelAddWord.Size = new Size(608, 471);
            panelAddWord.TabIndex = 10;
            panelAddWord.Visible = false;
            // 
            // btnX
            // 
            btnX.BackColor = Color.Transparent;
            btnX.BackgroundImage = Properties.Resources.EKIS;
            btnX.BackgroundImageLayout = ImageLayout.Stretch;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Location = new Point(409, 361);
            btnX.Name = "btnX";
            btnX.Size = new Size(64, 49);
            btnX.TabIndex = 4;
            btnX.TabStop = false;
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.BackgroundImage = Properties.Resources.CHECK;
            btnConfirm.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Location = new Point(262, 361);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(78, 59);
            btnConfirm.TabIndex = 3;
            btnConfirm.TabStop = false;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // textBoxSentence
            // 
            textBoxSentence.BackColor = Color.FromArgb(255, 233, 154);
            textBoxSentence.BorderStyle = BorderStyle.None;
            textBoxSentence.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxSentence.Location = new Point(150, 290);
            textBoxSentence.Name = "textBoxSentence";
            textBoxSentence.PlaceholderText = "✍️ How is it used in a sentence?";
            textBoxSentence.Size = new Size(325, 24);
            textBoxSentence.TabIndex = 2;
            textBoxSentence.TabStop = false;
            // 
            // textBoxMeaning
            // 
            textBoxMeaning.BackColor = Color.FromArgb(255, 233, 154);
            textBoxMeaning.BorderStyle = BorderStyle.None;
            textBoxMeaning.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxMeaning.Location = new Point(150, 220);
            textBoxMeaning.Name = "textBoxMeaning";
            textBoxMeaning.PlaceholderText = "📖 What does it mean?";
            textBoxMeaning.Size = new Size(325, 24);
            textBoxMeaning.TabIndex = 1;
            textBoxMeaning.TabStop = false;
            // 
            // textBoxWord
            // 
            textBoxWord.BackColor = Color.FromArgb(255, 233, 154);
            textBoxWord.BorderStyle = BorderStyle.None;
            textBoxWord.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxWord.Location = new Point(148, 159);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.PlaceholderText = "\t🐝 What's the new word?";
            textBoxWord.Size = new Size(325, 24);
            textBoxWord.TabIndex = 0;
            textBoxWord.TabStop = false;
            // 
            // panelDeleteAccount
            // 
            panelDeleteAccount.BackColor = SystemColors.ActiveCaption;
            panelDeleteAccount.BackgroundImage = Properties.Resources.DELETE_ACCOUNT;
            panelDeleteAccount.BackgroundImageLayout = ImageLayout.Stretch;
            panelDeleteAccount.Controls.Add(btnCancel);
            panelDeleteAccount.Controls.Add(btnDelete);
            panelDeleteAccount.Controls.Add(txtboxpassword);
            panelDeleteAccount.Controls.Add(txtboxUsername);
            panelDeleteAccount.Location = new Point(312, 29);
            panelDeleteAccount.Name = "panelDeleteAccount";
            panelDeleteAccount.Size = new Size(561, 396);
            panelDeleteAccount.TabIndex = 10;
            panelDeleteAccount.Visible = false;
            panelDeleteAccount.Paint += panelDeleteAccount_Paint;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.FromArgb(255, 178, 44);
            btnCancel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(133, 72, 54);
            btnCancel.Location = new Point(345, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 25);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(255, 178, 44);
            btnDelete.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(133, 72, 54);
            btnDelete.Location = new Point(84, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 25);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Account";
            btnDelete.Click += btnDelete_Click;
            // 
            // txtboxpassword
            // 
            txtboxpassword.BackColor = Color.FromArgb(255, 233, 154);
            txtboxpassword.BorderStyle = BorderStyle.None;
            txtboxpassword.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtboxpassword.Location = new Point(168, 263);
            txtboxpassword.Name = "txtboxpassword";
            txtboxpassword.PlaceholderText = "Enter your secret buzzword...";
            txtboxpassword.Size = new Size(263, 20);
            txtboxpassword.TabIndex = 1;
            txtboxpassword.TabStop = false;
            // 
            // txtboxUsername
            // 
            txtboxUsername.BackColor = Color.FromArgb(255, 233, 154);
            txtboxUsername.BorderStyle = BorderStyle.None;
            txtboxUsername.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtboxUsername.Location = new Point(168, 205);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.PlaceholderText = "Enter your hive name...";
            txtboxUsername.Size = new Size(291, 20);
            txtboxUsername.TabIndex = 0;
            txtboxUsername.TabStop = false;
            // 
            // panelAccountSetting
            // 
            panelAccountSetting.BackColor = Color.FromArgb(138, 104, 81);
            panelAccountSetting.BackgroundImage = Properties.Resources.panelAccSettings;
            panelAccountSetting.BackgroundImageLayout = ImageLayout.Stretch;
            panelAccountSetting.Controls.Add(btntrash);
            panelAccountSetting.Controls.Add(btnLogOut);
            panelAccountSetting.Location = new Point(-2, 41);
            panelAccountSetting.Name = "panelAccountSetting";
            panelAccountSetting.Size = new Size(130, 128);
            panelAccountSetting.TabIndex = 10;
            panelAccountSetting.Visible = false;
            panelAccountSetting.Paint += panelAccountSetting_Paint;
            // 
            // btntrash
            // 
            btntrash.AutoSize = true;
            btntrash.BackColor = Color.FromArgb(225, 239, 232);
            btntrash.FlatStyle = FlatStyle.Flat;
            btntrash.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntrash.ForeColor = Color.Red;
            btntrash.Location = new Point(48, 89);
            btntrash.Name = "btntrash";
            btntrash.Size = new Size(48, 16);
            btntrash.TabIndex = 1;
            btntrash.Text = "Delete";
            btntrash.Click += btntrash_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.BackColor = Color.FromArgb(225, 239, 232);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.FromArgb(133, 72, 54);
            btnLogOut.Location = new Point(40, 32);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(57, 16);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Log Out";
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panelSearchResult
            // 
            panelSearchResult.BackgroundImage = Properties.Resources.searchresult1;
            panelSearchResult.BackgroundImageLayout = ImageLayout.Stretch;
            panelSearchResult.Controls.Add(btnSearchBack);
            panelSearchResult.Controls.Add(lblResultSentence);
            panelSearchResult.Controls.Add(lblResultMeaning);
            panelSearchResult.Controls.Add(lblResultWord);
            panelSearchResult.Location = new Point(23, 175);
            panelSearchResult.Name = "panelSearchResult";
            panelSearchResult.Size = new Size(229, 188);
            panelSearchResult.TabIndex = 2;
            panelSearchResult.Visible = false;
            panelSearchResult.Paint += panelSearchResult_Paint;
            // 
            // btnSearchBack
            // 
            btnSearchBack.BackgroundImage = Properties.Resources.backbutton;
            btnSearchBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchBack.FlatAppearance.BorderSize = 0;
            btnSearchBack.FlatStyle = FlatStyle.Flat;
            btnSearchBack.Location = new Point(175, 6);
            btnSearchBack.Name = "btnSearchBack";
            btnSearchBack.Size = new Size(45, 31);
            btnSearchBack.TabIndex = 3;
            btnSearchBack.UseVisualStyleBackColor = true;
            btnSearchBack.Click += btnSearchBack_Click;
            // 
            // lblResultSentence
            // 
            lblResultSentence.BackColor = Color.FromArgb(71, 60, 56);
            lblResultSentence.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultSentence.ForeColor = Color.FromArgb(225, 239, 232);
            lblResultSentence.Location = new Point(80, 147);
            lblResultSentence.Name = "lblResultSentence";
            lblResultSentence.Size = new Size(140, 41);
            lblResultSentence.TabIndex = 2;
            lblResultSentence.Text = "Not Found";
            // 
            // lblResultMeaning
            // 
            lblResultMeaning.BackColor = Color.FromArgb(71, 60, 56);
            lblResultMeaning.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultMeaning.ForeColor = Color.FromArgb(225, 239, 232);
            lblResultMeaning.Location = new Point(80, 109);
            lblResultMeaning.Name = "lblResultMeaning";
            lblResultMeaning.Size = new Size(140, 36);
            lblResultMeaning.TabIndex = 1;
            lblResultMeaning.Text = "Not Found";
            // 
            // lblResultWord
            // 
            lblResultWord.BackColor = Color.FromArgb(71, 60, 56);
            lblResultWord.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultWord.ForeColor = Color.FromArgb(225, 239, 232);
            lblResultWord.Location = new Point(80, 69);
            lblResultWord.Name = "lblResultWord";
            lblResultWord.Size = new Size(140, 19);
            lblResultWord.TabIndex = 0;
            lblResultWord.Text = "Not Found";
            lblResultWord.Click += lblResultWord_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.GradientActiveCaption;
            btnRefresh.Location = new Point(198, 402);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(54, 16);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelUpdateWord
            // 
            panelUpdateWord.BackgroundImage = Properties.Resources.UpdatePanel;
            panelUpdateWord.BackgroundImageLayout = ImageLayout.Stretch;
            panelUpdateWord.Controls.Add(btnConfirmUpdate);
            panelUpdateWord.Controls.Add(btnCancelUpdate);
            panelUpdateWord.Controls.Add(textBoxNewSentence);
            panelUpdateWord.Controls.Add(textBoxNewMeaning);
            panelUpdateWord.Controls.Add(textBoxNewWord);
            panelUpdateWord.Location = new Point(297, 54);
            panelUpdateWord.Name = "panelUpdateWord";
            panelUpdateWord.Size = new Size(528, 355);
            panelUpdateWord.TabIndex = 12;
            panelUpdateWord.Visible = false;
            // 
            // btnConfirmUpdate
            // 
            btnConfirmUpdate.BackColor = Color.Transparent;
            btnConfirmUpdate.BackgroundImage = Properties.Resources.CHECK;
            btnConfirmUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmUpdate.FlatAppearance.BorderSize = 0;
            btnConfirmUpdate.FlatStyle = FlatStyle.Flat;
            btnConfirmUpdate.Location = new Point(233, 269);
            btnConfirmUpdate.Name = "btnConfirmUpdate";
            btnConfirmUpdate.Size = new Size(71, 44);
            btnConfirmUpdate.TabIndex = 4;
            btnConfirmUpdate.UseVisualStyleBackColor = false;
            btnConfirmUpdate.Click += btnConfirmUpdate_Click;
            // 
            // btnCancelUpdate
            // 
            btnCancelUpdate.BackColor = Color.Transparent;
            btnCancelUpdate.BackgroundImage = Properties.Resources.EKIS;
            btnCancelUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelUpdate.FlatAppearance.BorderSize = 0;
            btnCancelUpdate.FlatStyle = FlatStyle.Flat;
            btnCancelUpdate.Location = new Point(351, 269);
            btnCancelUpdate.Name = "btnCancelUpdate";
            btnCancelUpdate.Size = new Size(71, 44);
            btnCancelUpdate.TabIndex = 3;
            btnCancelUpdate.UseVisualStyleBackColor = false;
            btnCancelUpdate.Click += btnCancelUpdate_Click;
            // 
            // textBoxNewSentence
            // 
            textBoxNewSentence.BackColor = Color.FromArgb(255, 233, 154);
            textBoxNewSentence.BorderStyle = BorderStyle.None;
            textBoxNewSentence.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewSentence.Location = new Point(142, 215);
            textBoxNewSentence.Name = "textBoxNewSentence";
            textBoxNewSentence.PlaceholderText = "         Enter new sentence...";
            textBoxNewSentence.Size = new Size(285, 20);
            textBoxNewSentence.TabIndex = 2;
            textBoxNewSentence.TabStop = false;
            // 
            // textBoxNewMeaning
            // 
            textBoxNewMeaning.BackColor = Color.FromArgb(255, 233, 154);
            textBoxNewMeaning.BorderStyle = BorderStyle.None;
            textBoxNewMeaning.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewMeaning.Location = new Point(142, 167);
            textBoxNewMeaning.Name = "textBoxNewMeaning";
            textBoxNewMeaning.PlaceholderText = "         Enter new meaning...";
            textBoxNewMeaning.Size = new Size(285, 20);
            textBoxNewMeaning.TabIndex = 1;
            textBoxNewMeaning.TabStop = false;
            // 
            // textBoxNewWord
            // 
            textBoxNewWord.BackColor = Color.FromArgb(255, 233, 154);
            textBoxNewWord.BorderStyle = BorderStyle.None;
            textBoxNewWord.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewWord.Location = new Point(142, 120);
            textBoxNewWord.Name = "textBoxNewWord";
            textBoxNewWord.PlaceholderText = "         Enter new word...";
            textBoxNewWord.Size = new Size(285, 20);
            textBoxNewWord.TabIndex = 0;
            textBoxNewWord.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FINAL_FRAME;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 526);
            Controls.Add(panelViewVocabularies);
            Controls.Add(panelUpdateWord);
            Controls.Add(panelDeleteAccount);
            Controls.Add(btnRefresh);
            Controls.Add(panelSearchResult);
            Controls.Add(panelAddWord);
            Controls.Add(panelAccountSetting);
            Controls.Add(lblTotalWords);
            Controls.Add(lblUser2);
            Controls.Add(lblGameMode);
            Controls.Add(lblAddWord);
            Controls.Add(btnViewVocabularies);
            Controls.Add(btnSearch);
            Controls.Add(txtbxSearch);
            Controls.Add(lblUser1);
            Controls.Add(btnArrowDown);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panelViewVocabularies.ResumeLayout(false);
            panelViewVocabularies.PerformLayout();
            panelAddWord.ResumeLayout(false);
            panelAddWord.PerformLayout();
            panelDeleteAccount.ResumeLayout(false);
            panelDeleteAccount.PerformLayout();
            panelAccountSetting.ResumeLayout(false);
            panelAccountSetting.PerformLayout();
            panelSearchResult.ResumeLayout(false);
            panelUpdateWord.ResumeLayout(false);
            panelUpdateWord.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArrowDown;
        private Label lblUser1;
        private TextBox txtbxSearch;
        private Button btnSearch;
        private Label btnViewVocabularies;
        private Label lblAddWord;
        private Label lblGameMode;
        private Label lblUser2;
        private Label lblTotalWords;
        private Label lblUser3;
        private Button btnSeeAll;
        private Label lblWord1;
        private Label lblword3;
        private Label lblword4;
        private Label lblword5;
        private Label lblword6;
        private Label label1;
        private Panel panelViewVocabularies;
        private Button btnAddWord1;
        private Label lblSentence2;
        private Label lblSentence1;
        private Label lblmeaning2;
        private Label lblMeaning1;
        private Label lblword2;
        private Button btnDeleteWord2;
        private Button btnDeleteWord1;
        private Button btnAddWord2;
        private Panel panelDeleteAccount;
        private TextBox txtboxUsername;
        private Label btnCancel;
        private Label btnDelete;
        private TextBox txtboxpassword;
        private Panel panelAddWord;
        private TextBox textBoxWord;
        private TextBox textBoxSentence;
        private TextBox textBoxMeaning;
        private Button btnConfirm;
        private Button btnX;
        private Panel panelAccountSetting;
        private Label btntrash;
        private Label btnLogOut;
        private Panel panelSearchResult;
        private Label lblResultWord;
        private Button btnSearchBack;
        private Label lblResultSentence;
        private Label lblResultMeaning;
        private Label btnRefresh;
        private Panel panelUpdateWord;
        private TextBox textBoxNewWord;
        private Button btnConfirmUpdate;
        private Button btnCancelUpdate;
        private TextBox textBoxNewSentence;
        private TextBox textBoxNewMeaning;
    }
}