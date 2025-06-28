namespace PVBDesktop
{
    partial class ViewAll
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
            panelViewAll = new Panel();
            buttonback = new Button();
            textBoxViewAll = new TextBox();
            panelViewAll.SuspendLayout();
            SuspendLayout();
            // 
            // panelViewAll
            // 
            panelViewAll.BackgroundImage = Properties.Resources.panelViewAll;
            panelViewAll.BackgroundImageLayout = ImageLayout.Stretch;
            panelViewAll.Controls.Add(textBoxViewAll);
            panelViewAll.Controls.Add(buttonback);
            panelViewAll.Location = new Point(163, 33);
            panelViewAll.Name = "panelViewAll";
            panelViewAll.Size = new Size(680, 520);
            panelViewAll.TabIndex = 0;
            // 
            // buttonback
            // 
            buttonback.BackgroundImage = Properties.Resources.back_icon;
            buttonback.BackgroundImageLayout = ImageLayout.Stretch;
            buttonback.FlatAppearance.BorderSize = 0;
            buttonback.FlatStyle = FlatStyle.Flat;
            buttonback.Location = new Point(564, 38);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(67, 45);
            buttonback.TabIndex = 1;
            buttonback.UseVisualStyleBackColor = true;
            buttonback.Click += buttonback_Click;
            // 
            // textBoxViewAll
            // 
            textBoxViewAll.BackColor = Color.FromArgb(255, 233, 154);
            textBoxViewAll.BorderStyle = BorderStyle.None;
            textBoxViewAll.Location = new Point(84, 190);
            textBoxViewAll.Multiline = true;
            textBoxViewAll.Name = "textBoxViewAll";
            textBoxViewAll.ScrollBars = ScrollBars.Vertical;
            textBoxViewAll.Size = new Size(547, 290);
            textBoxViewAll.TabIndex = 2;
            textBoxViewAll.TextChanged += textBoxViewAll_TextChanged;
            // 
            // ViewAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 233, 154);
            ClientSize = new Size(1000, 565);
            Controls.Add(panelViewAll);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewAll";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ViewAll_Load;
            panelViewAll.ResumeLayout(false);
            panelViewAll.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelViewAll;
        private Button buttonback;
        private TextBox textBoxViewAll;
    }
}