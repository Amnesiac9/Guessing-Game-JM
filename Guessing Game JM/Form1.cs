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
         * 
         * John Moreau
         * CSS133
         * 4/16/2023
         * Simple Guessing Game :)
         * Guess a number between 3 different ranges, selectable by the user.
         * Up to 3 High Scores are saved for each difficulty.
         * Saves and loads high scores to a csv file.
         * 
         */


        /*
         * SOURCES
         * 
         * Writing data to a Grid View
         * https://stackoverflow.com/questions/33494332/reading-and-displaying-data-from-csv-file-on-windows-form-application-using-c-sh
         * 
         * Reading and writing to a file, class and list syntax
         * https://www.geeksforgeeks.org/how-to-read-and-write-a-text-file-in-c-sharp/
         * https://stackoverflow.com/questions/18757097/writing-data-into-csv-file-in-c-sharp
         * https://www.youtube.com/watch?v=IT8bT3NsaRg
         * https://www.youtube.com/watch?v=fRaSeLYYrcQ
         * 
         * Dictionaries and lists
         * https://stackoverflow.com/questions/7914830/what-is-the-difference-between-list-and-dictionary-in-c-sharp
         * https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections
         * 
         */

        // High Score class structure
        public class HighScoreEntry
        {
            public string Difficulty { get; set; }
            public string Score { get; set; }
            public string PlayerName { get; set; }
            public string Timestamp { get; set; }

        }

       



        // Global Variables
        private int randomNumber; // class level variable to store the random number
        private int guesses; // class level variable to store the number of guesses
        int maxGuesses; // class level variable to store the max number of guesses

        // High Score Lists
        List<HighScoreEntry> easyHighScores = new List<HighScoreEntry>(); // class level List to store the easy high scores
        List<HighScoreEntry> normalHighScores = new List<HighScoreEntry>(); // class level List to store the medium high scores
        List<HighScoreEntry> hardHighScores = new List<HighScoreEntry>(); // class level List to store the hard high scores

        // Create a dictionary to store the high scores by difficulty, each difficulty will have a list of high scores
        // Currently unused
        // Dictionary<int, List<HighScoreEntry>> highScores = new Dictionary<int, List<HighScoreEntry>>();


        public FormMain()
        {
            InitializeComponent();
        }

        //////////////////////
        //*    Main Form   *//
        //////////////////////
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Get high scores from csv file if it exists
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
            readHighScoresToDataTable();


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

            // Get the difficulty and Player Name from settings
            updateSettings();

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

            // Save options to settings and update player name
            Properties.Settings.Default.Difficulty = currentDifficulty;
            Properties.Settings.Default.PlayerName = textBoxPlayerName.Text;
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

        ///////////////////////
        //* MAIN GAME PANEL *//
        ///////////////////////

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
            string difficulty = Properties.Settings.Default.Difficulty; // Get the difficulty
            labelDifficultyValue.Text = difficulty; // Set the difficulty value label
            textBoxResponse.Text = "Random number generated. Make your first guess!"; // Reset the text box
            labelGuessCount.Text = "0"; // Reset the guess count label
            textBoxGuess.Text = ""; // Reset the guess text box
            this.guesses = 0; // Set the number of guesses to 0

            // Set the maximum value for the random number generator and limit guesses based on the difficulty
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

            } 
            else // Hard
            {
                // Set the maximum value to 50
                max = 50;
                maxGuesses = 10;
                labelMaxGuesses.Text = "/ 10";
                labelDifficultyValue.ForeColor = Color.Red;
                labelRangeValue.Text = "1 - 50";

            }
            
            Random random = new Random(); // Create a random number generator
            this.randomNumber = random.Next(1, max); // Generate a random number between 1 and the maximum value

            // Enable the guess button and text box
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
                textBoxGuess.Text = ""; // Clear the text box
                textBoxGuess.Focus(); // Set focus to the text box
                return; // Exit the method
            }

            
            guesses++; // Increment the number of guesses
            labelGuessCount.Text = $"{guesses}"; // Update the guess count label

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

                // Disable the guess button and text box
                buttonGuess.Enabled = false;
                textBoxGuess.Enabled = false;

                // Play again?
                textBoxResponse.AppendText (Environment.NewLine + "To play again, press restart.");
    
            }
        }

        //////////////////////////////////
        // High Scores helper functions //
        //////////////////////////////////

        // Read high scores to data table
        private void readHighScoresToDataTable()
        {
            // Return if the file can't be found
            string filePath = Path.Combine(Application.StartupPath, "HighScores.csv");
            if (!File.Exists(filePath))
            {
                return;
            }

            // Create a data table to hold the high scores
            DataTable dataTable = new DataTable();

            StreamReader sr = new StreamReader(filePath);
            int columnCount = 0;
            while (columnCount < 4)
            {
                string[] line = sr.ReadLine().Split(',');
                if (line.Length == 4)
                {
                    // Add the header columns
                    dataTable.Columns.Add(line[0]);
                    dataTable.Columns.Add(line[1]);
                    dataTable.Columns.Add(line[2]);
                    dataTable.Columns.Add(line[3]);
                    columnCount = 4;
                }
            }

            // Hard
            // Loop through the lines in the file and add the scores to my data table
            for (int i = 0; i < hardHighScores.Count; i++)
            {
                // Read line from file
                string[] line = sr.ReadLine().Split(',');
                dataTable.Rows.Add(line);
            }
            // Normal
            for (int i = 0; i < normalHighScores.Count; i++)
            {
                // Read line from file
                string[] line = sr.ReadLine().Split(',');
                dataTable.Rows.Add(line);
            }
            // Easy
            for (int i = 0; i < easyHighScores.Count; i++)
            {
                // Read line from file
                string[] line = sr.ReadLine().Split(',');
                dataTable.Rows.Add(line);
            }

            // Set the data source for the data grid view to the data we just read in
            dataGridViewHighScores.DataSource = dataTable;

            // Close the stream reader
            sr.Close();

        }

        // Get the high scores from CSV file
        private void readHighScores()
        {
            string filePath = Path.Combine(Application.StartupPath, "HighScores.csv");
            if (!File.Exists(filePath))
            {
                return;
            }

            // Open Stream Reader
            StreamReader sr = new StreamReader(filePath);

            // Read and ignore first line of headers
            int headers = 0;
            while (headers < 1)
            {
                string[] line = sr.ReadLine().Split(',');
                headers++;
            }

            // Loop through lines and add to correct difficulty list
            while (!sr.EndOfStream)
            {   
                // Read line from file
                string[] line = sr.ReadLine().Split(',');
                // Prepare high score entry
                HighScoreEntry highScoreEntry = new HighScoreEntry();

                // Check for difficulty
                if (line[0] == "Easy")
                {
                    highScoreEntry.Difficulty = line[0];
                    highScoreEntry.Score = line[1];
                    highScoreEntry.PlayerName = line[2];
                    highScoreEntry.Timestamp = line[3];
                    easyHighScores.Add(highScoreEntry);
                }
                else if (line[0] == "Normal")
                {
                    highScoreEntry.Difficulty = line[0];
                    highScoreEntry.Score = line[1];
                    highScoreEntry.PlayerName = line[2];
                    highScoreEntry.Timestamp = line[3];
                    normalHighScores.Add(highScoreEntry);
                }
                else if (line[0] == "Hard")
                {
                    highScoreEntry.Difficulty = line[0];
                    highScoreEntry.Score = line[1];
                    highScoreEntry.PlayerName = line[2];
                    highScoreEntry.Timestamp = line[3];
                    hardHighScores.Add(highScoreEntry);
                }
            }

            // Close the stream reader
            sr.Close();
        }





        // Write high scores to CSV file
        private void writeHighScores()
        {
            // Clear the contents of the HighScores.csv file if it exists
            string filePath = Path.Combine(Application.StartupPath, "HighScores.csv");
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
                
            


            // Create new stream writer
            StreamWriter sw = new StreamWriter(filePath, true);

            //Headers
            sw.WriteLine("Difficulty, Score, PlayerName, Date");

            // Write the high scores to the csv file
            //Hard
            for (int i = 0;i < hardHighScores.Count;i++)
            {
                sw.WriteLine(hardHighScores[i].Difficulty + "," + hardHighScores[i].Score + "," + hardHighScores[i].PlayerName + "," + hardHighScores[i].Timestamp);

            }
            //Normal
            for (int i = 0; i < normalHighScores.Count;i++)
            {
                sw.WriteLine(normalHighScores[i].Difficulty + "," + normalHighScores[i].Score + "," + normalHighScores[i].PlayerName + "," + normalHighScores[i].Timestamp);
            }
            // Easy
            for (int i =0; i < easyHighScores.Count; i++)
            {
                sw.WriteLine(easyHighScores[i].Difficulty + "," + easyHighScores[i].Score + "," + easyHighScores[i].PlayerName + "," + easyHighScores[i].Timestamp);
            }


            sw.Close();

        }



        // Update high score lists and return true if new high score
        private bool updateHighScores(int guesses)
        {
            // Get difficulty
            string difficulty = Properties.Settings.Default.Difficulty;
            // Get today's date as a string
            string today = DateTime.Now.ToString("MM/dd/yyyy");
            // Declare placeholder high score entry
            List<HighScoreEntry> currentHighScores = new List<HighScoreEntry>();

            bool isNewHighScore = false;


            // Get the array of the current difficulty high scores
            if (difficulty == "Easy")
                currentHighScores = easyHighScores;
            else if (difficulty == "Normal")
                currentHighScores = normalHighScores;
            else if (difficulty == "Hard")
                currentHighScores = hardHighScores;

            // Check if there's room for a new high score (Max 3 per difficulty)
            if (currentHighScores.Count < 3)
            {
                isNewHighScore = true;
                // Prepare high score entry
                HighScoreEntry highScoreEntry = new HighScoreEntry();
                highScoreEntry.Difficulty = difficulty;
                highScoreEntry.Score = guesses.ToString();
                highScoreEntry.PlayerName = Properties.Settings.Default.PlayerName;
                highScoreEntry.Timestamp = today;
                currentHighScores.Add(highScoreEntry);
            }
            else
            {
                // Loop through each number in the current HighScores and see if my score is lower
                for (int i = 0; i < currentHighScores.Count; i++)
                {
                    if (int.Parse(currentHighScores[i].Score) > guesses)
                    {
                        isNewHighScore = true;
                        // Prepare high score entry
                        HighScoreEntry highScoreEntry = new HighScoreEntry();
                        highScoreEntry.Difficulty = difficulty;
                        highScoreEntry.Score = guesses.ToString();
                        highScoreEntry.PlayerName = Properties.Settings.Default.PlayerName;
                        highScoreEntry.Timestamp = today;
                        // Insert at the current index to shift the list down
                        currentHighScores.Insert(i, highScoreEntry);
                        // Fourth place removed from the list
                        currentHighScores.RemoveAt(currentHighScores.Count - 1);
                        // Break out of the loop since we found a lower score
                        break;
                    }
                }
            }

            // Sort high scores
            currentHighScores = currentHighScores.OrderBy(score => score.Score).ToList();


            // Set current high scores to the corresponding high scores list
            if (difficulty == "Easy")
                easyHighScores = currentHighScores;
            else if (difficulty == "Normal")
                normalHighScores = currentHighScores;
            else if (difficulty == "Hard")
                hardHighScores = currentHighScores;

            // Return true if new high score or false if not
            return isNewHighScore;
        }



        // Helper function to update the difficulty displayed in the ComboBox control
        private void updateSettings()
        {
            // Set the selected index of the ComboBox control to the difficulty level
            // After retrieving the default difficulty level from the settings
            string defaultDifficulty = Properties.Settings.Default.Difficulty;
            comboBoxDifficulty.SelectedIndex = comboBoxDifficulty.Items.IndexOf(defaultDifficulty);
            textBoxPlayerName.Text = Properties.Settings.Default.PlayerName;
        }

    }
}
