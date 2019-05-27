/**
 * Name: Kato Lefebvre
 * Student #: 991323245
 * Date: May 19th, 2019
 */

namespace KatoLefebvre_Assignment1
{
    /// <summary>
    /// Class that contains methods for a number game.
    /// </summary>
    public class NumberGame
    {
        private NumberList _numberList = new NumberList();
        private int rounds;
        private static int score;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public NumberGame()
        {
        }

        /// <summary>
        /// Resets rounds and score to default values (0).
        /// </summary>
        public void StartNewGame()
        {
            rounds = 0;
            score = 0;
        }

        /// <summary>
        /// Method that determines if the game is not over yet and generates a new number list.
        /// The score is calculated and stored.
        /// </summary>
        /// <returns>Integer array.</returns>
        public int[] PlayRound()
        {
            if (IsGameOver() == false)
                rounds++;
            int[] numbers = _numberList.FillNumberList();
            score += CalculateRoundScore();
            return numbers;
        }

        /// <summary>
        /// Method that returns the final score.
        /// </summary>
        /// <returns>Current score.</returns>
        public int GenerateResult()
        {
            return score;
        }

        /// <summary>
        /// Method that determines if the player has played 5 rounds.
        /// </summary>
        /// <returns>Whether or not the game is over.</returns>
        public bool IsGameOver()
        {
            if (rounds == 5)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method that calculates the score for the round based on the frequency of numbers in the array.
        /// </summary>
        /// <returns>Score for the current round.</returns>
        public int CalculateRoundScore()
        {
            int frequency = _numberList.CalculateFrequency();
            int roundScore = frequency * 10;
            return roundScore;
        }
    }
}