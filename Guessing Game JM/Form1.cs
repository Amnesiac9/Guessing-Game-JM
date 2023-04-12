using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game_JM
{
    public partial class FormMain : Form
    {

        // class level variable to store the random number
        private int randomNumber;
        // class level variable to store the number of guesses
        private int guesses;

        public FormMain()
        {
            InitializeComponent();
        }

        // Helper function to update the difficulty displayed in the ComboBox control
        private void updateDifficulty()
        {
            // Set the selected index of the ComboBox control to the difficulty level
            // After retrieving the default difficulty level from the settings
            string defaultDifficulty = Properties.Settings.Default.Difficulty;
            comboBoxDifficulty.SelectedIndex = comboBoxDifficulty.Items.IndexOf(defaultDifficulty);
        }


        //////////////////////
        //*    Main Form   *//
        //////////////////////

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateDifficulty();     
        }


        // Start button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the Main panel and bring to front
            panelMain.Visible = !panelMain.Visible;
            panelMain.BringToFront();

            // Set the FormMain accept button to the buttonGuess
            this.AcceptButton = buttonGuess;
            // Set the FormMain cancel button to the buttonMainMenu
            this.CancelButton = buttonMainMenu;

            // Set focus to the guess text box
            textBoxGuess.Focus();
            
            // Initialize the guessing game
            guessingGameInitialize();

        }

        // Exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit the app
            this.Close();
            
        }

        //////////////////////
        //* SETTINGS PANEL *//
        //////////////////////
        
        // Settings button
        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            // Open a new form when user clicks the Settings button and bring to front
            panelSettings.Visible = !panelSettings.Visible;
            panelSettings.BringToFront();

            // Get the difficulty
            updateDifficulty();

            // Set the FormMain accept button to the buttonSettingsAccept
            this.AcceptButton = buttonSettingsAccept;
            // Set the FormMain cancel button to the buttonCancel
            this.CancelButton = buttonCancel;

        }

        // Settings Accept button
        private void buttonSettingsAccept_Click(object sender, EventArgs e)
        {
            // Get the selected value from the ComboBox control
            string currentDifficulty = comboBoxDifficulty.SelectedItem.ToString();

            // Save the selected value to settings
            Properties.Settings.Default.Difficulty = currentDifficulty;
            Properties.Settings.Default.Save();

            // Toggle the visibility of settings panel
            panelSettings.Visible = !panelSettings.Visible;

            // Set the FormMain accept button to the buttonStart
            this.AcceptButton = buttonStart;
            // Set the FormMain cancel button to the buttonExit
            this.CancelButton = buttonExit;


        }

        // Settings Cancel button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the Settings panel
            panelSettings.Visible = !panelSettings.Visible;

            // Set the FormMain accept button back to Start
            this.AcceptButton = buttonStart;
            // Set the FormMain cancel button back to Exit
            this.CancelButton = buttonExit;


        }

        //////////////////
        //* MAIN PANEL *//
        //////////////////

        // Main Menu button
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the Main panel 
            panelMain.Visible = !panelMain.Visible;

            // Set the FormMain accept button back to Start
            this.AcceptButton = buttonStart;
            // Set the FormMain cancel button back to Exit
            this.CancelButton = buttonExit;
        }

        // Restart button
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            // Restart the game
            guessingGameInitialize();
            // Set focus to the guess text box
            textBoxGuess.Focus();
            // Clear the guess text box
            textBoxGuess.Text = "";
        }

        // Guess button
        private void buttonGuess_Click(object sender, EventArgs e)
        {   

            // Make guess
            guessingGameGuess();

        }


        //////////////////////////////////
        // Initialize the guessing game //
        //////////////////////////////////
        private void guessingGameInitialize()
        {
            // 1. Get the difficulty
            string difficulty = Properties.Settings.Default.Difficulty;
            // 1.a Set the difficulty value label
            labelDifficultyValue.Text = difficulty;
            // 1.c Reset the text box
            textBoxResponse.Text = "Random number generated. Make your first guess!";
            // 1.d Reset the guess count label
            labelGuessCount.Text = "0";
            // 2. Set the maximum value for the random number generator
            int max = 25;
            // 3. Set the maximum value for the random number generator based on the difficulty
            if (difficulty == "Easy")
            {
                // Set the maximum value to 10
                max = 10;
                labelDifficultyValue.ForeColor = Color.Green;
                labelRangeValue.Text = "1 - 10";
            }
            else if (difficulty == "Hard")
            {
                max = 50;
                labelDifficultyValue.ForeColor = Color.Red;
                labelRangeValue.Text = "1 - 50";
            } else
            {
                // Set the maximum value to 25
                max = 25;
                labelDifficultyValue.ForeColor = Color.Black;
                labelRangeValue.Text = "1 - 25";
            }
            // 4. Create a random number generator
            Random random = new Random();
            // 5. Generate a random number between 1 and the maximum value
            this.randomNumber = random.Next(1, max);
            // 6. Set the number of guesses to 0
            this.guesses = 0;
            // 7. Enable the guess button and text box
            buttonGuess.Enabled = true;
            textBoxGuess.Enabled = true;
        }

        ///////////////////////////////
        // Main Game, handle guesses //
        ///////////////////////////////
        private void guessingGameGuess()
        {
            int guess;
            // Get the user's guess and confirm it is a number
            while (!int.TryParse(textBoxGuess.Text, out guess))
            {
                // Display an error message
                MessageBox.Show("Please enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear the text box
                textBoxGuess.Text = "";
                // Set focus to the text box
                textBoxGuess.Focus();
                // Exit the method
                return;
            }
            
            // Increment the number of guesses
            guesses++;
            // Update the guess count label
            labelGuessCount.Text = $"{guesses}";
            // Check if the guess is too high
            if (guess > randomNumber)
            {
                // Add result message to the text box
                string resultMessage = "Too High, try again!";
                textBoxResponse.AppendText($"{Environment.NewLine}{guess}: {resultMessage}");
            }
            // Check if the guess is too low
            else if (guess < randomNumber)
            {
                // Add result message to the text box
                string resultMessage = "Too Low, try again!";
                textBoxResponse.AppendText($"{Environment.NewLine}{guess}: {resultMessage}");
            }
            else // The guess is correct
            {
                // Add result message to the text box
                textBoxResponse.AppendText($"{Environment.NewLine}~~Congratulations!~~ You guessed the number in {guesses} guesses.");
                textBoxResponse.AppendText (Environment.NewLine + "To play again, press restart.");
                // Disable the guess button and text box
                buttonGuess.Enabled = false;
                textBoxGuess.Enabled = false;
            }

        }


    }
}
