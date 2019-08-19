using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class logic
    {
    public class RUSSIAN_ROULETTE
    {
        private int bulletePosition;
        private int chamberPosition;

        public int Chances;
        public int AwayChoices;

        public static int Wins = 0;
        public static int Losses = 0;



        public RUSSIAN_ROULETTE()
        {
            AwayChoices = 2;
            Chances = 6;
        }

        /// <summary>
        /// Updates the away and total shots label after each gun click
        /// </summary>

        /// <summary>
        /// Checks if the gun is Spinned at least once and Loaded.
        /// i.e verifies if the bullet and chamber position not set to 0.
        /// </summary>
        public bool IsGunSpunAndLoaded()
        {
            if (bulletePosition == 0)
            {

                return false;
            }
            else if (chamberPosition == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// returns random integer between 1 to 6
        /// </summary>
        /// <returns></returns>
        private int GetRandomPosition()
        {
            Random random = new Random();
            return random.Next(1, 7);

        }

        /// <summary>
        /// Sets bullet postion to any random number between 1 to 6.
        /// Plays gun loading sound
        /// </summary>
        public void LoadGun()
        {
            bulletePosition = GetRandomPosition();

        }

        /// <summary>
        /// Sets current chamber position to any random integer between 1 to 6.
        /// Plays chamber spinning sound.
        /// </summary>
        public void SpinChamber()
        {
            chamberPosition = GetRandomPosition();

        }

        /// <summary>
        /// Increse the win count by one and display win message
        /// </summary>
        private void Win()
        {
            Wins++;

        }

        /// <summary>
        /// Increse the loss count by one and display loss message
        /// </summary>
        private void Loss()
        {
            Losses++;

        }

        /// <summary>
        /// Fires the shot and checks if the user won or lost. Plays the gun fire and empty
        /// gun shot sounds on respective occurances.
        /// </summary>
        /// <param name="">Gun postion: true if away else false</param>
        /// <returns>True if game is over. False if the game is not over</returns>




    
        }

    }




