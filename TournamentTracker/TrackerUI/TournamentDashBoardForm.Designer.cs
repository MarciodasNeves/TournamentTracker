namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            CreatePrizeLabel2 = new Label();
            loadExistingTournamentValue = new ComboBox();
            loadExistingTournamentLabel = new Label();
            LoadTournamentButtom = new Button();
            CreateTournamentButtom = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLabel2
            // 
            CreatePrizeLabel2.AutoSize = true;
            CreatePrizeLabel2.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePrizeLabel2.ForeColor = Color.FromArgb(51, 153, 255);
            CreatePrizeLabel2.Location = new Point(156, 69);
            CreatePrizeLabel2.Name = "CreatePrizeLabel2";
            CreatePrizeLabel2.Size = new Size(364, 50);
            CreatePrizeLabel2.TabIndex = 32;
            CreatePrizeLabel2.Text = "Tournament DasBoard";
            // 
            // loadExistingTournamentValue
            // 
            loadExistingTournamentValue.FormattingEnabled = true;
            loadExistingTournamentValue.Location = new Point(156, 258);
            loadExistingTournamentValue.Name = "loadExistingTournamentValue";
            loadExistingTournamentValue.Size = new Size(345, 38);
            loadExistingTournamentValue.TabIndex = 39;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            loadExistingTournamentLabel.Location = new Point(156, 215);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(345, 40);
            loadExistingTournamentLabel.TabIndex = 38;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButtom
            // 
            LoadTournamentButtom.FlatStyle = FlatStyle.Flat;
            LoadTournamentButtom.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadTournamentButtom.ForeColor = Color.FromArgb(51, 153, 255);
            LoadTournamentButtom.Location = new Point(251, 302);
            LoadTournamentButtom.Name = "LoadTournamentButtom";
            LoadTournamentButtom.Size = new Size(168, 82);
            LoadTournamentButtom.TabIndex = 40;
            LoadTournamentButtom.Text = "Load Tournament";
            LoadTournamentButtom.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButtom
            // 
            CreateTournamentButtom.FlatStyle = FlatStyle.Flat;
            CreateTournamentButtom.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButtom.ForeColor = Color.FromArgb(51, 153, 255);
            CreateTournamentButtom.Location = new Point(214, 390);
            CreateTournamentButtom.Name = "CreateTournamentButtom";
            CreateTournamentButtom.Size = new Size(255, 58);
            CreateTournamentButtom.TabIndex = 46;
            CreateTournamentButtom.Text = "Create Tournament";
            CreateTournamentButtom.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(678, 604);
            Controls.Add(CreateTournamentButtom);
            Controls.Add(LoadTournamentButtom);
            Controls.Add(loadExistingTournamentValue);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(CreatePrizeLabel2);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashBoardForm";
            Text = "Tournament DashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLabel2;
        private ComboBox loadExistingTournamentValue;
        private Label loadExistingTournamentLabel;
        private Button LoadTournamentButtom;
        private Button CreateTournamentButtom;
    }
}