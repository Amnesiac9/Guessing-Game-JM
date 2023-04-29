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
            this.panelSettings = new System.Windows.Forms.Panel();
            this.groupBoxPlayerSelect = new System.Windows.Forms.GroupBox();
            this.RadioButtonPlayer1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonPlayer3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonPlayer2 = new System.Windows.Forms.RadioButton();
            this.labelUsernameTextBox = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelSettingsMenu = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.buttonSettingsCancel = new System.Windows.Forms.Button();
            this.buttonSettingsAccept = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.numericUpDownGuess = new System.Windows.Forms.NumericUpDown();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelMaxGuesses = new System.Windows.Forms.Label();
            this.labelRangeValue = new System.Windows.Forms.Label();
            this.labelMinMax = new System.Windows.Forms.Label();
            this.labelDifficultyValue = new System.Windows.Forms.Label();
            this.labelDifficulty2 = new System.Windows.Forms.Label();
            this.labelGuessCount = new System.Windows.Forms.Label();
            this.labelGuess = new System.Windows.Forms.Label();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.panelHighScores = new System.Windows.Forms.Panel();
            this.labelHighScores = new System.Windows.Forms.Label();
            this.dataGridViewHighScores = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonHighScoresMainMenu = new System.Windows.Forms.Button();
            this.buttonHighScores = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.pictureBoxQuestionMarks = new System.Windows.Forms.PictureBox();
            this.labelHSLowest = new System.Windows.Forms.Label();
            this.labelHSHighest = new System.Windows.Forms.Label();
            this.labelHSAverage = new System.Windows.Forms.Label();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.panelSettings.SuspendLayout();
            this.groupBoxPlayerSelect.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuess)).BeginInit();
            this.panelHighScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMarks)).BeginInit();
            this.groupBoxStats.SuspendLayout();
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
            this.buttonStart.BackColor = System.Drawing.Color.LightGray;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.groupBoxPlayerSelect);
            this.panelSettings.Controls.Add(this.labelUsernameTextBox);
            this.panelSettings.Controls.Add(this.textBoxPlayerName);
            this.panelSettings.Controls.Add(this.labelSettingsMenu);
            this.panelSettings.Controls.Add(this.labelDifficulty);
            this.panelSettings.Controls.Add(this.comboBoxDifficulty);
            this.panelSettings.Controls.Add(this.buttonSettingsCancel);
            this.panelSettings.Controls.Add(this.buttonSettingsAccept);
            resources.ApplyResources(this.panelSettings, "panelSettings");
            this.panelSettings.Name = "panelSettings";
            // 
            // groupBoxPlayerSelect
            // 
            this.groupBoxPlayerSelect.Controls.Add(this.RadioButtonPlayer1);
            this.groupBoxPlayerSelect.Controls.Add(this.RadioButtonPlayer3);
            this.groupBoxPlayerSelect.Controls.Add(this.RadioButtonPlayer2);
            resources.ApplyResources(this.groupBoxPlayerSelect, "groupBoxPlayerSelect");
            this.groupBoxPlayerSelect.Name = "groupBoxPlayerSelect";
            this.groupBoxPlayerSelect.TabStop = false;
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
            // RadioButtonPlayer3
            // 
            resources.ApplyResources(this.RadioButtonPlayer3, "RadioButtonPlayer3");
            this.RadioButtonPlayer3.Name = "RadioButtonPlayer3";
            this.RadioButtonPlayer3.UseVisualStyleBackColor = true;
            this.RadioButtonPlayer3.CheckedChanged += new System.EventHandler(this.RadioButtonPlayer3_CheckedChanged);
            // 
            // RadioButtonPlayer2
            // 
            resources.ApplyResources(this.RadioButtonPlayer2, "RadioButtonPlayer2");
            this.RadioButtonPlayer2.Name = "RadioButtonPlayer2";
            this.RadioButtonPlayer2.UseVisualStyleBackColor = true;
            this.RadioButtonPlayer2.CheckedChanged += new System.EventHandler(this.RadioButtonPlayer2_CheckedChanged);
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
            this.comboBoxDifficulty.Text = global::Guessing_Game_JM.Properties.Settings.Default.Player1_Difficulty;
            // 
            // buttonSettingsCancel
            // 
            this.buttonSettingsCancel.BackColor = System.Drawing.Color.LightGray;
            this.buttonSettingsCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettingsCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSettingsCancel.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonSettingsCancel, "buttonSettingsCancel");
            this.buttonSettingsCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSettingsCancel.Name = "buttonSettingsCancel";
            this.buttonSettingsCancel.UseVisualStyleBackColor = false;
            this.buttonSettingsCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSettingsAccept
            // 
            this.buttonSettingsAccept.BackColor = System.Drawing.Color.LightGray;
            this.buttonSettingsAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettingsAccept.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonSettingsAccept, "buttonSettingsAccept");
            this.buttonSettingsAccept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSettingsAccept.Name = "buttonSettingsAccept";
            this.buttonSettingsAccept.UseVisualStyleBackColor = false;
            this.buttonSettingsAccept.Click += new System.EventHandler(this.buttonSettingsAccept_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.numericUpDownGuess);
            this.panelGame.Controls.Add(this.labelPlayerName);
            this.panelGame.Controls.Add(this.labelPlayer);
            this.panelGame.Controls.Add(this.labelMaxGuesses);
            this.panelGame.Controls.Add(this.labelRangeValue);
            this.panelGame.Controls.Add(this.labelMinMax);
            this.panelGame.Controls.Add(this.labelDifficultyValue);
            this.panelGame.Controls.Add(this.labelDifficulty2);
            this.panelGame.Controls.Add(this.labelGuessCount);
            this.panelGame.Controls.Add(this.labelGuess);
            this.panelGame.Controls.Add(this.buttonMainMenu);
            this.panelGame.Controls.Add(this.buttonRestart);
            this.panelGame.Controls.Add(this.buttonGuess);
            this.panelGame.Controls.Add(this.textBoxResponse);
            this.panelGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.panelGame, "panelGame");
            this.panelGame.Name = "panelGame";
            // 
            // numericUpDownGuess
            // 
            resources.ApplyResources(this.numericUpDownGuess, "numericUpDownGuess");
            this.numericUpDownGuess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownGuess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownGuess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGuess.Name = "numericUpDownGuess";
            this.numericUpDownGuess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPlayerName
            // 
            resources.ApplyResources(this.labelPlayerName, "labelPlayerName");
            this.labelPlayerName.ForeColor = System.Drawing.Color.Coral;
            this.labelPlayerName.Name = "labelPlayerName";
            // 
            // labelPlayer
            // 
            resources.ApplyResources(this.labelPlayer, "labelPlayer");
            this.labelPlayer.Name = "labelPlayer";
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
            // labelMinMax
            // 
            resources.ApplyResources(this.labelMinMax, "labelMinMax");
            this.labelMinMax.Name = "labelMinMax";
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
            this.buttonMainMenu.BackColor = System.Drawing.Color.LightGray;
            this.buttonMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonMainMenu, "buttonMainMenu");
            this.buttonMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.UseVisualStyleBackColor = false;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // buttonRestart
            // 
            resources.ApplyResources(this.buttonRestart, "buttonRestart");
            this.buttonRestart.BackColor = System.Drawing.Color.LightGray;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.LightGray;
            this.buttonGuess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuess.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonGuess, "buttonGuess");
            this.buttonGuess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // textBoxResponse
            // 
            resources.ApplyResources(this.textBoxResponse, "textBoxResponse");
            this.textBoxResponse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            // 
            // panelHighScores
            // 
            this.panelHighScores.Controls.Add(this.groupBoxStats);
            this.panelHighScores.Controls.Add(this.labelHighScores);
            this.panelHighScores.Controls.Add(this.dataGridViewHighScores);
            this.panelHighScores.Controls.Add(this.label6);
            this.panelHighScores.Controls.Add(this.buttonHighScoresMainMenu);
            resources.ApplyResources(this.panelHighScores, "panelHighScores");
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
            this.buttonHighScoresMainMenu.BackColor = System.Drawing.Color.LightGray;
            this.buttonHighScoresMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHighScoresMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHighScoresMainMenu.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonHighScoresMainMenu, "buttonHighScoresMainMenu");
            this.buttonHighScoresMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHighScoresMainMenu.Name = "buttonHighScoresMainMenu";
            this.buttonHighScoresMainMenu.UseVisualStyleBackColor = false;
            this.buttonHighScoresMainMenu.Click += new System.EventHandler(this.buttonHighScoreMainMenu_Click);
            // 
            // buttonHighScores
            // 
            this.buttonHighScores.BackColor = System.Drawing.Color.LightGray;
            this.buttonHighScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHighScores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHighScores.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonHighScores, "buttonHighScores");
            this.buttonHighScores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHighScores.Name = "buttonHighScores";
            this.buttonHighScores.UseVisualStyleBackColor = false;
            this.buttonHighScores.Click += new System.EventHandler(this.buttonHighScores_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Guessing_Game_JM.Properties.Resources.logout;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSettings.BackgroundImage = global::Guessing_Game_JM.Properties.Resources.settings;
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxQuestionMarks
            // 
            this.pictureBoxQuestionMarks.Image = global::Guessing_Game_JM.Properties.Resources.question_marks;
            resources.ApplyResources(this.pictureBoxQuestionMarks, "pictureBoxQuestionMarks");
            this.pictureBoxQuestionMarks.Name = "pictureBoxQuestionMarks";
            this.pictureBoxQuestionMarks.TabStop = false;
            // 
            // labelHSLowest
            // 
            resources.ApplyResources(this.labelHSLowest, "labelHSLowest");
            this.labelHSLowest.Name = "labelHSLowest";
            // 
            // labelHSHighest
            // 
            resources.ApplyResources(this.labelHSHighest, "labelHSHighest");
            this.labelHSHighest.Name = "labelHSHighest";
            // 
            // labelHSAverage
            // 
            resources.ApplyResources(this.labelHSAverage, "labelHSAverage");
            this.labelHSAverage.Name = "labelHSAverage";
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.labelHSLowest);
            this.groupBoxStats.Controls.Add(this.labelHSAverage);
            this.groupBoxStats.Controls.Add(this.labelHSHighest);
            resources.ApplyResources(this.groupBoxStats, "groupBoxStats");
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.TabStop = false;
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
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.pictureBoxQuestionMarks);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHighScores);
            this.Controls.Add(this.buttonSettings);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.groupBoxPlayerSelect.ResumeLayout(false);
            this.groupBoxPlayerSelect.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuess)).EndInit();
            this.panelHighScores.ResumeLayout(false);
            this.panelHighScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMarks)).EndInit();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button buttonSettingsAccept;
        private System.Windows.Forms.Button buttonSettingsCancel;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelSettingsMenu;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label labelGuessCount;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.Label labelDifficultyValue;
        private System.Windows.Forms.Label labelDifficulty2;
        private System.Windows.Forms.Label labelRangeValue;
        private System.Windows.Forms.Label labelMinMax;
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
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.GroupBox groupBoxPlayerSelect;
        private System.Windows.Forms.NumericUpDown numericUpDownGuess;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelHSAverage;
        private System.Windows.Forms.Label labelHSHighest;
        private System.Windows.Forms.Label labelHSLowest;
        private System.Windows.Forms.GroupBox groupBoxStats;
    }
}

