namespace PVBDesktop
{
    partial class GameMode
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
            panelGamemode = new Panel();
            btnScores = new Label();
            btnNext = new Label();
            lblGivenMeaning = new Label();
            btnSubmitAnswer = new Label();
            textBoxGuessWord = new TextBox();
            buttonExitgame = new Button();
            panelGamemode.SuspendLayout();
            SuspendLayout();
            // 
            // panelGamemode
            // 
            panelGamemode.BackgroundImage = Properties.Resources.GAMEMODE;
            panelGamemode.BackgroundImageLayout = ImageLayout.Stretch;
            panelGamemode.Controls.Add(btnScores);
            panelGamemode.Controls.Add(btnNext);
            panelGamemode.Controls.Add(lblGivenMeaning);
            panelGamemode.Controls.Add(btnSubmitAnswer);
            panelGamemode.Controls.Add(textBoxGuessWord);
            panelGamemode.Controls.Add(buttonExitgame);
            panelGamemode.Location = new Point(116, 50);
            panelGamemode.Name = "panelGamemode";
            panelGamemode.Size = new Size(755, 468);
            panelGamemode.TabIndex = 0;
            // 
            // btnScores
            // 
            btnScores.AutoSize = true;
            btnScores.BackColor = Color.FromArgb(225, 239, 232);
            btnScores.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScores.ForeColor = Color.FromArgb(133, 72, 54);
            btnScores.Location = new Point(453, 385);
            btnScores.Name = "btnScores";
            btnScores.Size = new Size(122, 23);
            btnScores.TabIndex = 5;
            btnScores.Text = "Show Score";
            btnScores.Click += btnQuit_Click_1;
            // 
            // btnNext
            // 
            btnNext.AutoSize = true;
            btnNext.BackColor = Color.FromArgb(225, 239, 232);
            btnNext.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(133, 72, 54);
            btnNext.Location = new Point(274, 385);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(55, 23);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.Click += btnNext_Click;
            // 
            // lblGivenMeaning
            // 
            lblGivenMeaning.FlatStyle = FlatStyle.Flat;
            lblGivenMeaning.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGivenMeaning.Location = new Point(209, 282);
            lblGivenMeaning.Name = "lblGivenMeaning";
            lblGivenMeaning.Size = new Size(422, 54);
            lblGivenMeaning.TabIndex = 3;
            lblGivenMeaning.Text = "meaning...";
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.AutoSize = true;
            btnSubmitAnswer.BackColor = Color.FromArgb(106, 198, 107);
            btnSubmitAnswer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitAnswer.Location = new Point(557, 227);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(59, 18);
            btnSubmitAnswer.TabIndex = 2;
            btnSubmitAnswer.Text = "SUBMIT";
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // textBoxGuessWord
            // 
            textBoxGuessWord.BackColor = Color.FromArgb(255, 233, 154);
            textBoxGuessWord.BorderStyle = BorderStyle.None;
            textBoxGuessWord.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxGuessWord.Location = new Point(209, 224);
            textBoxGuessWord.Name = "textBoxGuessWord";
            textBoxGuessWord.PlaceholderText = "Your answer...";
            textBoxGuessWord.Size = new Size(319, 19);
            textBoxGuessWord.TabIndex = 1;
            textBoxGuessWord.TabStop = false;
            // 
            // buttonExitgame
            // 
            buttonExitgame.BackgroundImage = Properties.Resources.ekisss1;
            buttonExitgame.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExitgame.FlatAppearance.BorderSize = 0;
            buttonExitgame.FlatStyle = FlatStyle.Flat;
            buttonExitgame.Location = new Point(628, 65);
            buttonExitgame.Name = "buttonExitgame";
            buttonExitgame.Size = new Size(45, 27);
            buttonExitgame.TabIndex = 0;
            buttonExitgame.UseVisualStyleBackColor = true;
            buttonExitgame.Click += buttonExitgame_Click;
            // 
            // GameMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 233, 154);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 565);
            Controls.Add(panelGamemode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameMode";
            panelGamemode.ResumeLayout(false);
            panelGamemode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGamemode;
        private Label btnSubmitAnswer;
        private TextBox textBoxGuessWord;
        private Button buttonExitgame;
        private Label btnNext;
        private Label lblGivenMeaning;
        private Label btnScores;
    }
}