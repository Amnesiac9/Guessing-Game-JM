using Guessing_Game_JM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game_JM
{ 
    public partial class FormMain : Form
    {

       /* 
        * John Moreau
        * CSS133
        * 4/16/2023
        * Simple Guessing Game :)
        * Saves high scores to a csv file
        * 
        * 
        */


        /*
         * SOURCES
         * 
         * Writing data to a Grid View
         * https://stackoverflow.com/questions/33494332/reading-and-displaying-data-from-csv-file-on-windows-form-application-using-c-sh
         * 
         * Reading and writing to a csv file
         * https://www.youtube.com/watch?v=IT8bT3NsaRg
         * https://www.youtube.com/watch?v=fRaSeLYYrcQ
         * 
         * 
         */

        // class level variable to store the random number
        private int randomNumber;
        // class level variable to store the number of guesses
        private int guesses;
        // class level variable to store the max number of guesses
        int maxGuesses;
        // class level array to store the easy high scores
        int[] easyHighScores = new int[5];
        // class level array to store the medium high scores
        int[] normalHighScores = new int[5];
        // class level array to store the hard high scores
        int[] hardHighScores = new int[5];
      
        


        public FormMain()
        {
            InitializeComponent();
        }

        //////////////////////
        //*    Main Form   *//
        //////////////////////

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Get high scores from csv file
            readHighScores();
        }

        // Start button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Initialize the guessing game
            guessingGameInitialize();

            // Toggle the visibility of the Main panel and bring to front
            panelMain.Visible = !panelMain.Visible;
            panelMain.BringToFront();

            // Set the FormMain accept button to the buttonGuess
            this.AcceptButton = buttonGuess;
            // Set the FormMain cancel button to the buttonMainMenu
            this.CancelButton = buttonMainMenu;

            // Set focus to the guess text box
            textBoxGuess.Focus();
        }

        // Exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the app
            this.Close(); 
        }

        // High Scores button
        private void buttonHighScores_Click(object sender, EventArgs e)
        {
            // Read the high scores from the csv file and display them in th data table
            readHighScores();


            // Toggle the visibility of the HighScores panel and bring to front
            panelHighScores.Visible = !panelHighScores.Visible;
            panelHighScores.BringToFront();

            // Set the FormMain accept button to the buttonGuess
            this.AcceptButton = buttonHighScoresMainMenu;
            // Set the FormMain cancel button to the buttonMainMenu
            this.CancelButton = buttonHighScoresMainMenu;

        }

        /////////////////////////
        //* HIGH SCORES PANEL *//
        /////////////////////////

        // High Scores Main Menu button
        private void buttonHighScoreMainMenu_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the HighScores panel
            panelHighScores.Visible = !panelHighScores.Visible;
            panelHighScores.SendToBack();
            // Set the FormMain accept button to the buttonStart
            this.AcceptButton = buttonStart;
            // Set the FormMain cancel button to the buttonExit
            this.CancelButton = buttonExit;
        }

        //////////////////////
        //* SETTINGS PANEL *//
        //////////////////////

        // Settings button
        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            // Open the settings panel when user clicks the Settings button and bring to front
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
            panelSettings.SendToBack();

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
            panelSettings.SendToBack();

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
            panelMain.SendToBack();

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
            // 1.e Reset the guess text box
            textBoxGuess.Text = "";
            // 2. Set the maximum value for the random number generator and limit guesses based on the difficulty
            int max;
            if (difficulty == "Easy")
            {
                // Set the maximum value to 10
                max = 10;
                maxGuesses = 5;
                labelMaxGuesses.Text = "/ 5";
                labelDifficultyValue.ForeColor = Color.Green;
                labelRangeValue.Text = "1 - 10";
            }
            else if (difficulty == "Normal")
            {
                // Set the maximum value to 25
                max = 25;
                maxGuesses = 8;
                labelMaxGuesses.Text = "/ 8";
                labelDifficultyValue.ForeColor = Color.Black;
                labelRangeValue.Text = "1 - 25";

            } else // Hard
            {
                // Set the maximum value to 50
                max = 50;
                maxGuesses = 10;
                labelMaxGuesses.Text = "/ 10";
                labelDifficultyValue.ForeColor = Color.Red;
                labelRangeValue.Text = "1 - 50";

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

            // Check for loss
            if (guesses >= maxGuesses && guess != randomNumber)
            {
                // Add result message to the text box
                textBoxResponse.AppendText($"{Environment.NewLine}~~You Lose!~~ The number was {randomNumber}.");
                textBoxResponse.AppendText(Environment.NewLine + "To play again, press restart.");
                // Disable the guess button and text box
                buttonGuess.Enabled = false;
                textBoxGuess.Enabled = false;
            }
            // Check if the guess is too high
            else if (guess > randomNumber)
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
                // Check for high score
                if (updateHighScores(guesses))
                {
                    textBoxResponse.AppendText($"{Environment.NewLine}~~~~ NEW HIGH SCORE! ~~~~");
                    // Write the high scores to the CSV file
                    writeHighScores();
                }
                    
                    
                textBoxResponse.AppendText (Environment.NewLine + "To play again, press restart.");
                // Disable the guess button and text box
                buttonGuess.Enabled = false;
                textBoxGuess.Enabled = false;
                
            }



        }

        //////////////////////////////////
        // High Scores helper functions //
        //////////////////////////////////
        
        // Get the high scores from CSV file
        private void readHighScores()
        {
            string filePath = Path.Combine(Application.StartupPath, "HighScores.csv");
            if (!File.Exists(filePath))
            {
                return;
            }

            // Create a data table to hold the high scores
            DataTable dataTable = new DataTable();

            StreamReader sr = new StreamReader(filePath);
            int columnCount = 0;
            while (columnCount < 1)
            {
                string[] line = sr.ReadLine().Split(',');
                if (line.Length == 3)
                {
                    // Add the high score to the data table
                    dataTable.Columns.Add(line[0]);
                    dataTable.Columns.Add(line[1]);
                    dataTable.Columns.Add(line[2]);
                    columnCount = 1;
                }
            }

            // Hard
            // Loop through the lines in the file and add the scores to my arrays and data table
            for (int i = 0; i < hardHighScores.Length; i++)
            {
                string[] line = sr.ReadLine().Split(',');
                if (int.TryParse(line[2], out int score))
                {
                    // Only add the high score if it is greater than 0 or an existing score
                    hardHighScores[i] = score;
                    if (score > 0)
                        dataTable.Rows.Add(line);
                }
            }
            // Normal
            for (int i = 0; i < normalHighScores.Length; i++)
            {
                string[] line = sr.ReadLine().Split(',');
                if (int.TryParse(line[2], out int score))
                {
                    normalHighScores[i] = score;
                    if (score > 0)
                        dataTable.Rows.Add(line);

                }
            }
            // Easy
            for (int i = 0; i < easyHighScores.Length; i++)
            {
                string[] line = sr.ReadLine().Split(',');
                if (int.TryParse(line[2], out int score))
                {
                    easyHighScores[i] = score;
                    if (score > 0)
                        dataTable.Rows.Add(line);
                }
            }

            // Set the data source for the data grid view to the data we just read in
            dataGridViewHighScores.DataSource = dataTable;

            // Close the stream reader
            sr.Close();
        }



        // Write high scores to CSV file
        private void writeHighScores()
        {
            // Clear the contents of the HighScores.csv file if it exists
            string filePath = Path.Combine(Application.StartupPath, "HighScores.csv");
            if (File.Exists(filePath))
                File.WriteAllText(filePath, "");
            
            // Get today's date as a string
            string today = DateTime.Now.ToString("MM/dd/yyyy");

            // Create new stream writer
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine("Difficulty,Date,Score");

            // Write the high scores to the csv file
            //Hard
            for (int i = 0; i < hardHighScores.Length; i++)
            {
                sw.WriteLine("Hard," + today + "," + hardHighScores[i]);
            }
            //Normal
            for (int i = 0; i < normalHighScores.Length; i++)
            {
                sw.WriteLine("Normal," + today + "," + normalHighScores[i]);
            }
            //Easy
            for (int i = 0; i < easyHighScores.Length; i++)
            {
                sw.WriteLine("Easy," + today + "," + easyHighScores[i]);
            }
            sw.Close();

        }



        // Update high score arrays and return true if new high score
        private bool updateHighScores(int guesses)
        {
            string difficulty = Properties.Settings.Default.Difficulty;
            int[] currentHighScores = new int[5];
            bool isNewHighScore = false;

            // Get the array of the current difficulty high scores
            if (difficulty == "Easy")
                currentHighScores = easyHighScores;
            else if (difficulty == "Normal")
                currentHighScores = normalHighScores;
            else if (difficulty == "Hard")
                currentHighScores = hardHighScores;

            // Loop through each number in the current HighScores and see if my score is lower
            for (int i = 0; i < currentHighScores.Length; i++)
            {
                if (currentHighScores[i] > guesses || currentHighScores[i] == 0)
                {
                    currentHighScores[i] = guesses;
                    isNewHighScore = true;
                    // Set current high scores to the corresponding high scores array
                    if (difficulty == "Easy")
                        easyHighScores = currentHighScores;
                    else if (difficulty == "Normal")
                        normalHighScores = currentHighScores;
                    else if (difficulty == "Hard")
                        hardHighScores = currentHighScores;
                    // Break out of the loop since we found a lower score
                    break;
                }
            }
           // Return true if new high score or false if not
            return isNewHighScore;
        }



        // Helper function to update the difficulty displayed in the ComboBox control
        private void updateDifficulty()
        {
            // Set the selected index of the ComboBox control to the difficulty level
            // After retrieving the default difficulty level from the settings
            string defaultDifficulty = Properties.Settings.Default.Difficulty;
            comboBoxDifficulty.SelectedIndex = comboBoxDifficulty.Items.IndexOf(defaultDifficulty);
        }

    }
}
