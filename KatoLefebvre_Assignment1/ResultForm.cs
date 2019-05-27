/**
 * Name: Kato Lefebvre
 * Student #: 991323245
 * Date: May 19th, 2019
 */

using System;
using System.Windows.Forms;

namespace KatoLefebvre_Assignment1
{
    public partial class ResultForm : Form
    {
        NumberGame numberGame = new NumberGame();

        /// <summary>
        /// Result Form method.
        /// Initializes and displays the final score and wehther the player won or lost.
        /// </summary>
        public ResultForm()
        {
            InitializeComponent();

            // final score is generated
            int finalScore = numberGame.GenerateResult();
            score.Text = "The game is over! Your final score is " + finalScore + ".";

            // result is determined by the score
            if (finalScore == 100)
                finalresult.Text = "Game Draw!";
            else if (finalScore > 100)
                finalresult.Text = "You Win!";
            else
                finalresult.Text = "You Lose! Try Again!";
        }

        /// <summary>
        /// Method for the beginning of a new game through the result form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewGame_Click(object sender, EventArgs e)
        {
            numberGame.StartNewGame();
            this.Hide();
            GameForm game = new GameForm();
            game.Show();
        }
    }
}