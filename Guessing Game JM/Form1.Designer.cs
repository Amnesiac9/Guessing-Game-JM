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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.labelUsernameTextBox = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelSettingsMenu = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSettingsAccept = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelMaxGuesses = new System.Windows.Forms.Label();
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
            this.panelHighScores = new System.Windows.Forms.Panel();
            this.labelHighScores = new System.Windows.Forms.Label();
            this.dataGridViewHighScores = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonHighScoresMainMenu = new System.Windows.Forms.Button();
            this.buttonHighScores = new System.Windows.Forms.Button();
            this.pictureBoxQuestionMarks = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.RadioButtonPlayer1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonPlayer2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonPlayer3 = new System.Windows.Forms.RadioButton();
            this.panelSettings.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelHighScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // labelAuthor
            // 
            resources.ApplyResources(this.labelAuthor, "labelAuthor");
            this.labelAuthor.Name = "labelAuthor";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart.FlatAppearance.BorderSize = 12;
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.RadioButtonPlayer3);
            this.panelSettings.Controls.Add(this.RadioButtonPlayer2);
            this.panelSettings.Controls.Add(this.RadioButtonPlayer1);
            this.panelSettings.Controls.Add(this.labelUsernameTextBox);
            this.panelSettings.Controls.Add(this.textBoxPlayerName);
            this.panelSettings.Controls.Add(this.labelSettingsMenu);
            this.panelSettings.Controls.Add(this.labelDifficulty);
            this.panelSettings.Controls.Add(this.comboBoxDifficulty);
            this.panelSettings.Controls.Add(this.buttonCancel);
            this.panelSettings.Controls.Add(this.buttonSettingsAccept);
            resources.ApplyResources(this.panelSettings, "panelSettings");
            this.panelSettings.Name = "panelSettings";
            // 
            // labelUsernameTextBox
            // 
            resources.ApplyResources(this.labelUsernameTextBox, "labelUsernameTextBox");
            this.labelUsernameTextBox.Name = "labelUsernameTextBox";
            // 
            // textBoxPlayerName
            // 
            resources.ApplyResources(this.textBoxPlayerName, "textBoxPlayerName");
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            // 
            // labelSettingsMenu
            // 
            resources.ApplyResources(this.labelSettingsMenu, "labelSettingsMenu");
            this.labelSettingsMenu.Name = "labelSettingsMenu";
            // 
            // labelDifficulty
            // 
            resources.ApplyResources(this.labelDifficulty, "labelDifficulty");
            this.labelDifficulty.Name = "labelDifficulty";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxDifficulty, "comboBoxDifficulty");
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            resources.GetString("comboBoxDifficulty.Items"),
            resources.GetString("comboBoxDifficulty.Items1"),
            resources.GetString("comboBoxDifficulty.Items2")});
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Text = global::Guessing_Game_JM.Properties.Settings.Default.Difficulty;
            // 
            // buttonCancel
            // 
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSettingsAccept
            // 
            this.buttonSettingsAccept.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonSettingsAccept, "buttonSettingsAccept");
            this.buttonSettingsAccept.Name = "buttonSettingsAccept";
            this.buttonSettingsAccept.UseVisualStyleBackColor = true;
            this.buttonSettingsAccept.Click += new System.EventHandler(this.buttonSettingsAccept_Click);
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
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // labelMaxGuesses
            // 
            resources.ApplyResources(this.labelMaxGuesses, "labelMaxGuesses");
            this.labelMaxGuesses.Name = "labelMaxGuesses";
            // 
            // labelRangeValue
            // 
            resources.ApplyResources(this.labelRangeValue, "labelRangeValue");
            this.labelRangeValue.Name = "labelRangeValue";
            // 
            // labelCurrentRangeText
            // 
            resources.ApplyResources(this.labelCurrentRangeText, "labelCurrentRangeText");
            this.labelCurrentRangeText.Name = "labelCurrentRangeText";
            // 
            // labelDifficultyValue
            // 
            resources.ApplyResources(this.labelDifficultyValue, "labelDifficultyValue");
            this.labelDifficultyValue.Name = "labelDifficultyValue";
            // 
            // labelDifficulty2
            // 
            resources.ApplyResources(this.labelDifficulty2, "labelDifficulty2");
            this.labelDifficulty2.Name = "labelDifficulty2";
            // 
            // labelGuessCount
            // 
            resources.ApplyResources(this.labelGuessCount, "labelGuessCount");
            this.labelGuessCount.Name = "labelGuessCount";
            // 
            // labelGuess
            // 
            resources.ApplyResources(this.labelGuess, "labelGuess");
            this.labelGuess.Name = "labelGuess";
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonMainMenu, "buttonMainMenu");
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonRestart, "buttonRestart");
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonGuess
            // 
            this.buttonGuess.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonGuess, "buttonGuess");
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.textBoxGuess, "textBoxGuess");
            this.textBoxGuess.Name = "textBoxGuess";
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.textBoxResponse, "textBoxResponse");
            this.textBoxResponse.Name = "textBoxResponse";
            // 
            // panelHighScores
            // 
            resources.ApplyResources(this.panelHighScores, "panelHighScores");
            this.panelHighScores.Controls.Add(this.labelHighScores);
            this.panelHighScores.Controls.Add(this.dataGridViewHighScores);
            this.panelHighScores.Controls.Add(this.label6);
            this.panelHighScores.Controls.Add(this.buttonHighScoresMainMenu);
            this.panelHighScores.Name = "panelHighScores";
            // 
            // labelHighScores
            // 
            resources.ApplyResources(this.labelHighScores, "labelHighScores");
            this.labelHighScores.Name = "labelHighScores";
            // 
            // dataGridViewHighScores
            // 
            this.dataGridViewHighScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHighScores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHighScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHighScores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHighScores.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.dataGridViewHighScores, "dataGridViewHighScores");
            this.dataGridViewHighScores.Name = "dataGridViewHighScores";
            this.dataGridViewHighScores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewHighScores.RowTemplate.Height = 28;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // buttonHighScoresMainMenu
            // 
            this.buttonHighScoresMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonHighScoresMainMenu, "buttonHighScoresMainMenu");
            this.buttonHighScoresMainMenu.Name = "buttonHighScoresMainMenu";
            this.buttonHighScoresMainMenu.UseVisualStyleBackColor = true;
            this.buttonHighScoresMainMenu.Click += new System.EventHandler(this.buttonHighScoreMainMenu_Click);
            // 
            // buttonHighScores
            // 
            this.buttonHighScores.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonHighScores, "buttonHighScores");
            this.buttonHighScores.Name = "buttonHighScores";
            this.buttonHighScores.UseVisualStyleBackColor = true;
            this.buttonHighScores.Click += new System.EventHandler(this.buttonHighScores_Click);
            // 
            // pictureBoxQuestionMarks
            // 
            this.pictureBoxQuestionMarks.Image = global::Guessing_Game_JM.Properties.Resources.question_marks;
            resources.ApplyResources(this.pictureBoxQuestionMarks, "pictureBoxQuestionMarks");
            this.pictureBoxQuestionMarks.Name = "pictureBoxQuestionMarks";
            this.pictureBoxQuestionMarks.TabStop = false;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Image = global::Guessing_Game_JM.Properties.Resources.settings;
            resources.ApplyResources(this.pictureBoxSettings, "pictureBoxSettings");
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // RadioButtonPlayer1
            // 
            resources.ApplyResources(this.RadioButtonPlayer1, "RadioButtonPlayer1");
            this.RadioButtonPlayer1.Checked = true;
            this.RadioButtonPlayer1.Name = "RadioButtonPlayer1";
            this.RadioButtonPlayer1.TabStop = true;
            this.RadioButtonPlayer1.UseVisualStyleBackColor = true;
            this.RadioButtonPlayer1.CheckedChanged += new System.EventHandler(this.RadioButtonPlayer1_CheckedChanged);
            // 
            // RadioButtonPlayer2
            // 
            resources.ApplyResources(this.RadioButtonPlayer2, "RadioButtonPlayer2");
            this.RadioButtonPlayer2.Name = "RadioButtonPlayer2";
            this.RadioButtonPlayer2.UseVisualStyleBackColor = true;
            this.RadioButtonPlayer2.CheckedChanged += new System.EventHandler(this.RadioButtonPlayer2_CheckedChanged);
            // 
            // RadioButtonPlayer3
            // 
            resources.ApplyResources(this.RadioButtonPlayer3, "RadioButtonPlayer3");
            this.RadioButtonPlayer3.Name = "RadioButtonPlayer3";
            this.RadioButtonPlayer3.UseVisualStyleBackColor = true;
            this.RadioButtonPlayer3.CheckedChanged += new System.EventHandler(this.RadioButtonPlayer3_CheckedChanged);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonStart;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.buttonExit;
            this.Controls.Add(this.panelHighScores);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.pictureBoxQuestionMarks);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHighScores);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelHighScores.ResumeLayout(false);
            this.panelHighScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxQuestionMarks;
        private System.Windows.Forms.Button buttonHighScores;
        private System.Windows.Forms.Panel panelHighScores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHighScoresMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewHighScores;
        private System.Windows.Forms.Label labelHighScores;
        private System.Windows.Forms.Label labelUsernameTextBox;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.RadioButton RadioButtonPlayer3;
        private System.Windows.Forms.RadioButton RadioButtonPlayer2;
        private System.Windows.Forms.RadioButton RadioButtonPlayer1;
    }
}

