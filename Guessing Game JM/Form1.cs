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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Guessing_Game_JM
{
    public partial class FormMain : Form
    {

        /* 
         * 
         * John Moreau
         * CSS133
         * 4/17/2023
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
         * https://stackoverflow.com/questions/19456408/add-a-highscore-system-thats-saves-the-data
         * https://www.geeksforgeeks.org/how-to-read-and-write-a-text-file-in-c-sharp/
         * https://stackoverflow.com/questions/18757097/writing-data-into-csv-file-in-c-sharp
         * https://www.youtube.com/watch?v=IT8bT3NsaRg
         * https://www.youtube.com/watch?v=fRaSeLYYrcQ
         * 
         * Dictionaries and lists
         * https://stackoverflow.com/questions/7914830/what-is-the-difference-between-list-and-dictionary-in-c-sharp
         * https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections
         * Sorting list 
         * https://stackoverflow.com/questions/11062338/c-sharp-create-high-score-text-file-and-reorder-the-results
         * 
         * Append to list
         * https://stackoverflow.com/questions/1825568/append-a-lists-contents-to-another-list-c-sharp
         * 
         */

        // High Score class structure
        [Serializable()]
        public class HighScoreEntry
        {
            public string Difficulty { get; set; }
            public string Score { get; set; }
            public string PlayerName { get; set; }
            public string Timestamp { get; set; }

        }

        // Easy method/constructor to create a new HighScoreEntry
        // Since the only thing that changes during the game is the number of guesses, we can just pass that in
        private HighScoreEntry newHighScoreEntry(int guesses)
        {
            HighScoreEntry highScoreEntry = new HighScoreEntry
            {
                Difficulty = Properties.Settings.Default.Difficulty,
                Score = guesses.ToString(),
                PlayerName = Properties.Settings.Default.PlayerName,
                Timestamp = DateTime.Now.ToString("M/dd/yyyy")
            };

            return highScoreEntry;
        }


        // Global Variables - What's a good way to avoid class level variables in this case?
        private int randomNumber; // class level variable to store the random number
        private int guesses; // class level variable to store the number of guesses
        int maxGuesses; // class level variable to store the max number of guesses
        int maxRandomNumber; // class level variable to store the max random number


        // High Score Lists
        List<HighScoreEntry> easyHighScores = new List<HighScoreEntry>(); // class level List to store the easy high scores
        List<HighScoreEntry> normalHighScores = new List<HighScoreEntry>(); // class level List to store the normal high scores
        List<HighScoreEntry> hardHighScores = new List<HighScoreEntry>(); // class level List to store the hard high scores

        // Store a list for each difficulty inside of a dictionary?
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
            readHighScoresXML();
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
            // Read the high scores from the csv file and display them in the data table
            // TODO: Update this to read from the list instead of the csv file
            //readHighScoresToDataTable();
            readHighScoresToTable();

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
            // Clear the guess text box
            textBoxGuess.Text = "";
            // Set focus to the guess text box
            textBoxGuess.Focus();

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
            
            if (difficulty == "Easy")
            {
                // Set the maximum value to 10
                maxRandomNumber = 10;
                maxGuesses = 5;
                labelMaxGuesses.Text = "/ 5";
                labelDifficultyValue.ForeColor = Color.Green;
                labelRangeValue.Text = "1 - 10";
            }
            else if (difficulty == "Normal")
            {
                // Set the maximum value to 25
                maxRandomNumber = 25;
                maxGuesses = 8;
                labelMaxGuesses.Text = "/ 8";
                labelDifficultyValue.ForeColor = Color.Black;
                labelRangeValue.Text = "1 - 25";

            }
            else // Hard
            {
                // Set the maximum value to 50
                maxRandomNumber = 50;
                maxGuesses = 10;
                labelMaxGuesses.Text = "/ 10";
                labelDifficultyValue.ForeColor = Color.Red;
                labelRangeValue.Text = "1 - 50";

            }

            Random random = new Random(); // Create a random number generator
            this.randomNumber = random.Next(1, maxRandomNumber); // Generate a random number between 1 and the maximum value

            // Enable the guess button and text box
            buttonGuess.Enabled = true;
            textBoxGuess.Enabled = true;
        }


        /////////////////////////////////
        //* Main Game, handle guesses *//
        /////////////////////////////////
        private void guessingGameGuess()
        {
            int guess;
            // Get the user's guess and confirm it is a number
            while (!int.TryParse(textBoxGuess.Text, out guess) || guess > maxRandomNumber)
            {
                // Display an error message
                MessageBox.Show($"Please enter a number between 0 and {maxRandomNumber}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    writeHighScoresXML();
                }

                // Disable the guess button and text box
                buttonGuess.Enabled = false;
                textBoxGuess.Enabled = false;

                // Play again?
                textBoxResponse.AppendText(Environment.NewLine + "To play again, press restart.");

            }
        }

        //////////////////////////////////
        // High Scores helper functions //
        //////////////////////////////////


        // Read high scores from lists into data table
        private void readHighScoresToTable()
        {
            // Create a data table to hold the high scores
            DataTable dataTable = new DataTable();

            // Add header columns "Difficulty, Score, PlayerName, Date"
            dataTable.Columns.Add("Difficulty");
            dataTable.Columns.Add("Score");
            dataTable.Columns.Add("PlayerName");
            dataTable.Columns.Add("Date");

            // Hard
            foreach (HighScoreEntry entry in hardHighScores)
            {
                DataRow row = dataTable.NewRow();
                {
                    row[0] = entry.Difficulty;
                    row[1] = entry.Score;
                    row[2] = entry.PlayerName;
                    row[3] = entry.Timestamp;
                    dataTable.Rows.Add(row);
                }
            }
            // Normal
            foreach (HighScoreEntry entry in normalHighScores)
            {
                DataRow row = dataTable.NewRow();
                {
                    row[0] = entry.Difficulty;
                    row[1] = entry.Score;
                    row[2] = entry.PlayerName;
                    row[3] = entry.Timestamp;
                    dataTable.Rows.Add(row);
                }
            }
            // Easy
            foreach (HighScoreEntry entry in easyHighScores)
            {
                DataRow row = dataTable.NewRow();
                {
                    row[0] = entry.Difficulty;
                    row[1] = entry.Score;
                    row[2] = entry.PlayerName;
                    row[3] = entry.Timestamp;
                    dataTable.Rows.Add(row);
                }
            }

            // Set the data source for the data grid view to the data we just read in
            dataGridViewHighScores.DataSource = dataTable;

        }


        // Get the high scores from XML file
        private void readHighScoresXML()
        {
            // Get filepath and check if the file exists
            string filePath = Path.Combine(Application.StartupPath, "HighScores.xml");
            if (!File.Exists(filePath))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<HighScoreEntry>), "Guessing_Game_JM.FormMain.HighScores");
            object obj;
            using (var sr = new StreamReader(filePath))
            {
                obj = serializer.Deserialize(sr.BaseStream);
            }

            // Create a list of all high scores
            List<HighScoreEntry> highScores;

            highScores = (List<HighScoreEntry>)obj;

            // Split out highScores by difficulty
            foreach(HighScoreEntry score in highScores)
            {
                if (score.Difficulty == "Easy")
                {
                    easyHighScores.Add(score);
                }
                else if (score.Difficulty == "Normal")
                {
                    normalHighScores.Add(score);
                }
                else // Hard
                {
                    hardHighScores.Add(score);
                }

            }
        }



        // Write high scores to XML
        private void writeHighScoresXML()
        {

            // Get filepath
            string filePath = Path.Combine(Application.StartupPath, "HighScores.xml");

            // Create a list of all high scores
            List<HighScoreEntry> highScores = new List<HighScoreEntry>();
            highScores.AddRange(easyHighScores);
            highScores.AddRange(normalHighScores);
            highScores.AddRange(hardHighScores);
            
            // Serialize to file
            XmlSerializer serializer = new XmlSerializer(typeof(List<HighScoreEntry>), "Guessing_Game_JM.FormMain.HighScores");
            using (var sr = new StreamWriter(filePath, false))
            {
                serializer.Serialize(sr.BaseStream, highScores);
            }



        }

        // If new high score update high score lists and return true 
        private bool updateHighScores(int guesses)
        {
            // Declare bool to return
            bool isNewHighScore = false;

            // Declare placeholder high score entry
            List<HighScoreEntry> currentHighScores;

            // Get the list of the current difficulty high scores
            currentHighScores = getCurrentDifficultyScores();

            // Check if there's room for a new high score (Max 3 per difficulty)
            if (currentHighScores.Count < 3)
            {
                // Set bool to true for return
                isNewHighScore = true;
                // Prepare high score entry
                HighScoreEntry highScoreEntry = newHighScoreEntry(guesses);
                currentHighScores.Add(highScoreEntry);
                // Sort list by lowest score using lambda to create new sorted list and reassign our current list to the sorted one
                currentHighScores = currentHighScores.OrderBy(score => score.Score).ToList();
            }
            else
            {
                //    Loop through each number in the current HighScores and see if my score is lower
                for (int i = 0; i < currentHighScores.Count; i++)
                {
                    if (int.Parse(currentHighScores[i].Score) > guesses)
                    {
                        isNewHighScore = true;
                        // Prepare high score entry
                        HighScoreEntry highScoreEntry = newHighScoreEntry(guesses);
                        // Insert at the current index to shift the list down
                        currentHighScores.Insert(i, highScoreEntry);
                        // Fourth place removed from the list
                        currentHighScores.RemoveAt(currentHighScores.Count - 1);
                        // Break out of the loop since we found a lower score
                        break;
                    }
                }
            }


            // Set current high scores to the corresponding high scores list
            setCurrentDifficultyScores(currentHighScores);

            // Return true if new high score or false if not
            return isNewHighScore;
        }


        // Helper function to return the current difficulty's corresponding list
        private List<HighScoreEntry> getCurrentDifficultyScores()
        {
            string difficulty = Properties.Settings.Default.Difficulty;
            // Set current high scores to the corresponding high scores list
            if (difficulty == "Easy")
                return easyHighScores;
            else if (difficulty == "Normal")
                return normalHighScores;
            else if (difficulty == "Hard")
                return hardHighScores;

            return null;
        }

        // Helper function to update the current difficulty's list.
        private void setCurrentDifficultyScores(List<HighScoreEntry> currentDifficultyScores )
        {
            string difficulty = Properties.Settings.Default.Difficulty;
            // Set current high scores to the corresponding high scores list
            switch (difficulty)
            {
                case "Easy":
                    easyHighScores = currentDifficultyScores;
                    break;
                case "Normal":
                    normalHighScores = currentDifficultyScores;
                    break;
                case "Hard":
                    hardHighScores = currentDifficultyScores;
                    break;
                default:
                    break;
            }
        }

        ////////////////////////////////
        //   Other helper functions   //
        ////////////////////////////////

        // Helper function to update the difficulty displayed in the ComboBox control
        private void updateSettings()
        {
            // Set the selected index of the ComboBox control to the difficulty level saved in the settings
            string defaultDifficulty = Properties.Settings.Default.Difficulty;
            comboBoxDifficulty.SelectedIndex = comboBoxDifficulty.Items.IndexOf(defaultDifficulty);
            // Remember the player's updated name when opening the settings menu
            textBoxPlayerName.Text = Properties.Settings.Default.PlayerName;
        }



        /// 
        /// Deprecated /// - Safe to remove. Leave here for Teacher to see =)
        /// 

        /*
         * I left these here just for the teacher to see my initial struggles
         * They are no longer in use, but I did get them to work
         * I figured out a better way afterwards using XML
         * and didn't want to fully delete. I hope that's ok.
         * I would never leave things like this in production code.
         */

        // Read high scores to data table from CSV File (This did work)
        private void readHighScoresToTableFromCSV()
        {
            // Return if the file can't be found
            string filePath = Path.Combine(Application.StartupPath, "HighScores.csv");
            if (!File.Exists(filePath))
            {
                return;
            }

            // Create a data table to hold the high scores
            DataTable dataTable = new DataTable();

            // Create a stream reader to read the file
            StreamReader sr = new StreamReader(filePath);

            // Read the header line
            string[] line = sr.ReadLine().Split(',');
            // Add the header columns
            dataTable.Columns.Add(line[0]);
            dataTable.Columns.Add(line[1]);
            dataTable.Columns.Add(line[2]);
            dataTable.Columns.Add(line[3]);

            // Read the rest of the lines 
            while (!sr.EndOfStream)
            {
                // Read each line from file
                line = sr.ReadLine().Split(',');
                // Add each line to the data table
                dataTable.Rows.Add(line);
            }

            // Set the data source for the data grid view to the data we just read in
            dataGridViewHighScores.DataSource = dataTable;

            // Close the stream reader
            sr.Close();

        }

        //  Read the high scores from CSV file into my lists (This did work)
        private void readHighScores()
        {
            string filePath = Path.Combine(Application.StartupPath, "HighScores.csv");
            if (!File.Exists(filePath))
            {
                return;
            }

            // Open Stream Reader
            StreamReader sr = new StreamReader(filePath);

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

        // Write high scores to CSV file (This did work)
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
            for (int i = 0; i < hardHighScores.Count; i++)
            {
                sw.WriteLine(hardHighScores[i].Difficulty + "," + hardHighScores[i].Score + "," + hardHighScores[i].PlayerName + "," + hardHighScores[i].Timestamp);

            }
            //Normal
            for (int i = 0; i < normalHighScores.Count; i++)
            {
                sw.WriteLine(normalHighScores[i].Difficulty + "," + normalHighScores[i].Score + "," + normalHighScores[i].PlayerName + "," + normalHighScores[i].Timestamp);
            }
            // Easy
            for (int i = 0; i < easyHighScores.Count; i++)
            {
                sw.WriteLine(easyHighScores[i].Difficulty + "," + easyHighScores[i].Score + "," + easyHighScores[i].PlayerName + "," + easyHighScores[i].Timestamp);
            }

            sw.Close();

        }


    }
}
