/**
 * Name: Kato Lefebvre
 * Student #: 991323245
 * Date: May 19th, 2019
 */

using System;
using System.Collections.Generic;

namespace KatoLefebvre_Assignment1
{
    /// <summary>
    /// Class that creates the list of numbers used by NumberGame.
    /// </summary>
    public class NumberList
    {
        private int[] _numbers = new int[5];

        /// <summary>
        /// Method that fills the list of integers with randomly generated values.
        /// Returns the list of integers.
        /// </summary>
        /// <returns>Integer array.</returns>
        public int[] FillNumberList()
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                _numbers[i] = rand.Next(0, 9);
            }

            return _numbers;
        }

        /// <summary>
        /// Method that calculates the frequency of the numbers generated.
        /// Returns the frequency to be calculated into the score.
        /// </summary>
        /// <returns>Frequency as an integer.</returns>
        public int CalculateFrequency()
        {
            int frequency = 0;
            var dict = new Dictionary<int, int>(); // i used a dictionary to keep track of similar values
            foreach (int value in _numbers)
            {
                if (dict.ContainsKey(value))
                    dict[value]++; // if a number appears more than once, its value increases by 1 for each time it appears
                else
                    dict[value] = 1; // if a number only appears once in the array, its value is 1
            }
            foreach (var fq in dict)
            {
                if (fq.Value > 1)
                {
                    // this calculation takes into account if a number appears more than twice
                    // previously i had this: frequency++;
                    // but that didn't work if the number appears more than twice
                    frequency = fq.Value + frequency - 1;
                }
            }
            return frequency;
        }
    }
}