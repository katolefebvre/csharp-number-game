/**
 * Name: Kato Lefebvre
 * Student #: 991323245
 * Date: May 19th, 2019
 */

using System;
using System.Windows.Forms;

namespace KatoLefebvre_Assignment1
{
    public partial class GameForm : Form
    {
        private NumberGame numberGame = new NumberGame();
        private int progress = 0;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts a new game and resets all fields within the form to default values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewGame_Click(object sender, EventArgs e)
        {
            numberGame.StartNewGame();

            progress = 0;
            progressBar.Value = progress;
            number1.Text = "0";
            number2.Text = "0";
            number3.Text = "0";
            number4.Text = "0";
            number5.Text = "0";

            int currentScore = numberGame.GenerateResult();
            scoreLabel.Text = "Score: " + currentScore;
        }

        /// <summary>
        /// Generates random numbers and processes the score for each round.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateRandom_Click(object sender, EventArgs e)
        {
            // progress bar code - progress bar fills with each round that is played
            progressBar.Minimum = 0;
            progressBar.Maximum = 5;

            if (progress < 5)
            {
                // the numbers are generated and placed into each label
                int[] nums = numberGame.PlayRound();
                number1.Text = nums[0].ToString();
                number2.Text = nums[1].ToString();
                number3.Text = nums[2].ToString();
                number4.Text = nums[3].ToString();
                number5.Text = nums[4].ToString();

                // progress bar fills
                progress++;
                progressBar.Value = progress;

                // current score is shown to the player
                int currentScore = numberGame.GenerateResult();
                scoreLabel.Text = "Score: " + currentScore;
            }
            else // once 5 rounds have been played, the game ends and the results form is shown
            {
                this.Hide();
                ResultForm result = new ResultForm();
                result.Show();
            }
        }
    }
}