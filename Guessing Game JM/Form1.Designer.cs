namespace Guessing_Game_JM
{
    partial class FormMain
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.labelSettingsMenu = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSettingsAccept = new System.Windows.Forms.Button();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelRangeValue = new System.Windows.Forms.Label();
            this.labelCurrentRangeText = new System.Windows.Forms.Label();
            this.labelDifficultyValue = new System.Windows.Forms.Label();
            this.labelDifficulty2 = new System.Windows.Forms.Label();
            this.labelGuessCount = new System.Windows.Forms.Label();
            this.labelGuess = new System.Windows.Forms.Label();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.labelMaxGuesses = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Enabled = false;
            this.labelTitle.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(235, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(297, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Guessing Game";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(430, 54);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(103, 16);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "by John Moreau";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart.FlatAppearance.BorderSize = 12;
            this.buttonStart.Font = new System.Drawing.Font("Ancient Geek", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(279, 482);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(215, 87);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "&Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(12, 627);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 30);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.labelSettingsMenu);
            this.panelSettings.Controls.Add(this.labelDifficulty);
            this.panelSettings.Controls.Add(this.comboBoxDifficulty);
            this.panelSettings.Controls.Add(this.buttonCancel);
            this.panelSettings.Controls.Add(this.buttonSettingsAccept);
            this.panelSettings.Location = new System.Drawing.Point(3, 70);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(770, 594);
            this.panelSettings.TabIndex = 5;
            this.panelSettings.Visible = false;
            // 
            // labelSettingsMenu
            // 
            this.labelSettingsMenu.AutoSize = true;
            this.labelSettingsMenu.Font = new System.Drawing.Font("Atlanta", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingsMenu.Location = new System.Drawing.Point(265, 99);
            this.labelSettingsMenu.Name = "labelSettingsMenu";
            this.labelSettingsMenu.Size = new System.Drawing.Size(240, 44);
            this.labelSettingsMenu.TabIndex = 5;
            this.labelSettingsMenu.Text = "Settings Menu";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(295, 228);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(181, 22);
            this.labelDifficulty.TabIndex = 4;
            this.labelDifficulty.Text = "Select Difficulty Level";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(308, 263);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(154, 24);
            this.comboBoxDifficulty.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(344, 454);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSettingsAccept
            // 
            this.buttonSettingsAccept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSettingsAccept.Location = new System.Drawing.Point(334, 390);
            this.buttonSettingsAccept.Name = "buttonSettingsAccept";
            this.buttonSettingsAccept.Size = new System.Drawing.Size(100, 41);
            this.buttonSettingsAccept.TabIndex = 1;
            this.buttonSettingsAccept.Text = "&Accept";
            this.buttonSettingsAccept.UseVisualStyleBackColor = true;
            this.buttonSettingsAccept.Click += new System.EventHandler(this.buttonSettingsAccept_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Image = global::Guessing_Game_JM.Properties.Resources.settings;
            this.pictureBoxSettings.Location = new System.Drawing.Point(205, 482);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(66, 65);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 3;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelMaxGuesses);
            this.panelMain.Controls.Add(this.labelRangeValue);
            this.panelMain.Controls.Add(this.labelCurrentRangeText);
            this.panelMain.Controls.Add(this.labelDifficultyValue);
            this.panelMain.Controls.Add(this.labelDifficulty2);
            this.panelMain.Controls.Add(this.labelGuessCount);
            this.panelMain.Controls.Add(this.labelGuess);
            this.panelMain.Controls.Add(this.buttonMainMenu);
            this.panelMain.Controls.Add(this.buttonRestart);
            this.panelMain.Controls.Add(this.buttonGuess);
            this.panelMain.Controls.Add(this.textBoxGuess);
            this.panelMain.Controls.Add(this.textBoxResponse);
            this.panelMain.Location = new System.Drawing.Point(12, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(748, 567);
            this.panelMain.TabIndex = 6;
            this.panelMain.Visible = false;
            // 
            // labelRangeValue
            // 
            this.labelRangeValue.AutoSize = true;
            this.labelRangeValue.Location = new System.Drawing.Point(356, 75);
            this.labelRangeValue.Name = "labelRangeValue";
            this.labelRangeValue.Size = new System.Drawing.Size(38, 16);
            this.labelRangeValue.TabIndex = 10;
            this.labelRangeValue.Text = "1 - 50";
            // 
            // labelCurrentRangeText
            // 
            this.labelCurrentRangeText.AutoSize = true;
            this.labelCurrentRangeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentRangeText.Location = new System.Drawing.Point(339, 53);
            this.labelCurrentRangeText.Name = "labelCurrentRangeText";
            this.labelCurrentRangeText.Size = new System.Drawing.Size(71, 16);
            this.labelCurrentRangeText.TabIndex = 9;
            this.labelCurrentRangeText.Text = "Min | Max";
            // 
            // labelDifficultyValue
            // 
            this.labelDifficultyValue.AutoSize = true;
            this.labelDifficultyValue.Location = new System.Drawing.Point(170, 295);
            this.labelDifficultyValue.Name = "labelDifficultyValue";
            this.labelDifficultyValue.Size = new System.Drawing.Size(55, 16);
            this.labelDifficultyValue.TabIndex = 8;
            this.labelDifficultyValue.Text = "Medium";
            // 
            // labelDifficulty2
            // 
            this.labelDifficulty2.AutoSize = true;
            this.labelDifficulty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty2.Location = new System.Drawing.Point(94, 295);
            this.labelDifficulty2.Name = "labelDifficulty2";
            this.labelDifficulty2.Size = new System.Drawing.Size(70, 16);
            this.labelDifficulty2.TabIndex = 7;
            this.labelDifficulty2.Text = "Difficulty:";
            // 
            // labelGuessCount
            // 
            this.labelGuessCount.AutoSize = true;
            this.labelGuessCount.Location = new System.Drawing.Point(593, 295);
            this.labelGuessCount.Name = "labelGuessCount";
            this.labelGuessCount.Size = new System.Drawing.Size(0, 16);
            this.labelGuessCount.TabIndex = 6;
            // 
            // labelGuess
            // 
            this.labelGuess.AutoSize = true;
            this.labelGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuess.Location = new System.Drawing.Point(515, 295);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(72, 16);
            this.labelGuess.TabIndex = 5;
            this.labelGuess.Text = "Guesses:";
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMainMenu.Location = new System.Drawing.Point(117, 471);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(90, 48);
            this.buttonMainMenu.TabIndex = 4;
            this.buttonMainMenu.Text = "&Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRestart.Location = new System.Drawing.Point(526, 471);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(100, 48);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "&Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonGuess
            // 
            this.buttonGuess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuess.Location = new System.Drawing.Point(311, 351);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(126, 31);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "&Guess!";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxGuess.Location = new System.Drawing.Point(324, 323);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(100, 22);
            this.textBoxGuess.TabIndex = 1;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxResponse.Location = new System.Drawing.Point(89, 99);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(571, 193);
            this.textBoxResponse.TabIndex = 0;
            // 
            // labelMaxGuesses
            // 
            this.labelMaxGuesses.AutoSize = true;
            this.labelMaxGuesses.Location = new System.Drawing.Point(609, 295);
            this.labelMaxGuesses.Name = "labelMaxGuesses";
            this.labelMaxGuesses.Size = new System.Drawing.Size(116, 16);
            this.labelMaxGuesses.TabIndex = 11;
            this.labelMaxGuesses.Text = "labelMaxGuesses";
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(772, 669);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelSettings);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "FormMain";
            this.Text = "Guessing Game";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button buttonSettingsAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelSettingsMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label labelGuessCount;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.Label labelDifficultyValue;
        private System.Windows.Forms.Label labelDifficulty2;
        private System.Windows.Forms.Label labelRangeValue;
        private System.Windows.Forms.Label labelCurrentRangeText;
        private System.Windows.Forms.Label labelMaxGuesses;
    }
}

