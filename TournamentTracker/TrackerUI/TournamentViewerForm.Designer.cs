namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            TournamentName = new Label();
            Roundlabel = new Label();
            RoundDropDown = new ComboBox();
            UnplayedOnlyCheckBox = new CheckedListBox();
            MatchupListBox = new ListBox();
            TeamOneName = new Label();
            TeamOneScoreLabel = new Label();
            TeamOneScoreValue = new TextBox();
            TeamTwoScoreValue = new TextBox();
            TeamTwoScoreLabel = new Label();
            TeamTwoLabel = new Label();
            VS = new Label();
            scorebutton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(12, 16);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentName.Location = new Point(232, 16);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(150, 50);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            // 
            // Roundlabel
            // 
            Roundlabel.AutoSize = true;
            Roundlabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Roundlabel.ForeColor = Color.FromArgb(51, 153, 255);
            Roundlabel.Location = new Point(12, 116);
            Roundlabel.Name = "Roundlabel";
            Roundlabel.Size = new Size(99, 40);
            Roundlabel.TabIndex = 2;
            Roundlabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            RoundDropDown.FormattingEnabled = true;
            RoundDropDown.Location = new Point(117, 121);
            RoundDropDown.Name = "RoundDropDown";
            RoundDropDown.Size = new Size(265, 38);
            RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            UnplayedOnlyCheckBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnplayedOnlyCheckBox.ForeColor = Color.FromArgb(51, 153, 255);
            UnplayedOnlyCheckBox.FormattingEnabled = true;
            UnplayedOnlyCheckBox.Location = new Point(117, 200);
            UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            UnplayedOnlyCheckBox.Size = new Size(209, 42);
            UnplayedOnlyCheckBox.TabIndex = 4;
            // 
            // MatchupListBox
            // 
            MatchupListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 30;
            MatchupListBox.Location = new Point(12, 304);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(370, 152);
            MatchupListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneName.ForeColor = Color.FromArgb(51, 153, 255);
            TeamOneName.Location = new Point(456, 148);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(145, 40);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "Team One";
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TeamOneScoreLabel.Location = new Point(456, 202);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(87, 40);
            TeamOneScoreLabel.TabIndex = 7;
            TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            TeamOneScoreValue.Location = new Point(571, 207);
            TeamOneScoreValue.Name = "TeamOneScoreValue";
            TeamOneScoreValue.Size = new Size(100, 35);
            TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            TeamTwoScoreValue.Location = new Point(571, 421);
            TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            TeamTwoScoreValue.Size = new Size(100, 35);
            TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TeamTwoScoreLabel.Location = new Point(456, 416);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(87, 40);
            TeamTwoScoreLabel.TabIndex = 10;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoLabel
            // 
            TeamTwoLabel.AutoSize = true;
            TeamTwoLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TeamTwoLabel.Location = new Point(456, 362);
            TeamTwoLabel.Name = "TeamTwoLabel";
            TeamTwoLabel.Size = new Size(143, 40);
            TeamTwoLabel.TabIndex = 9;
            TeamTwoLabel.Text = "Team Two";
            // 
            // VS
            // 
            VS.AutoSize = true;
            VS.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VS.ForeColor = Color.FromArgb(51, 153, 255);
            VS.Location = new Point(525, 283);
            VS.Name = "VS";
            VS.Size = new Size(74, 40);
            VS.TabIndex = 12;
            VS.Text = "-VS-";
            // 
            // scorebutton
            // 
            scorebutton.FlatStyle = FlatStyle.Flat;
            scorebutton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scorebutton.ForeColor = Color.FromArgb(51, 153, 255);
            scorebutton.Location = new Point(673, 283);
            scorebutton.Name = "scorebutton";
            scorebutton.Size = new Size(102, 77);
            scorebutton.TabIndex = 13;
            scorebutton.Text = "Score";
            scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(798, 629);
            Controls.Add(scorebutton);
            Controls.Add(VS);
            Controls.Add(TeamTwoScoreValue);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(TeamTwoLabel);
            Controls.Add(TeamOneScoreValue);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(TeamOneName);
            Controls.Add(MatchupListBox);
            Controls.Add(UnplayedOnlyCheckBox);
            Controls.Add(RoundDropDown);
            Controls.Add(Roundlabel);
            Controls.Add(TournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label TournamentName;
        private Label Roundlabel;
        private ComboBox RoundDropDown;
        private CheckedListBox UnplayedOnlyCheckBox;
        private ListBox MatchupListBox;
        private Label TeamOneName;
        private Label TeamOneScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoLabel;
        private Label VS;
        private Button scorebutton;
    }
}
