﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RollTheDiceLearn
{
    internal class Gamerules
    {
        public static bool GameMaster(int dice_1_1, int dice_1_2, int dice_2_1, int dice_2_2)
        {
            bool player_equal;
            bool opponent_equal;
            int countEquals = 0;
            bool proceed = true;

            player_equal = dice_1_1 == dice_1_2;
            opponent_equal = dice_2_1 == dice_2_2;

            if (player_equal)
            {
                countEquals++;
            }
            if (opponent_equal)
            {
                countEquals++;
            }

            if (countEquals == 1)
            {
                if (player_equal)
                {
                    Console.WriteLine("You win!");
                }
                if (opponent_equal)
                {
                    Console.WriteLine("I win!");
                }
                proceed = false;
            }

            if (countEquals == 2)
            {
                if ((dice_1_1 + dice_1_2) > (dice_2_1 + dice_2_2))
                {
                    Console.WriteLine("You win!");
                    proceed = false;
                }
                if ((dice_1_1 + dice_1_2) < (dice_2_1 + dice_2_2))
                {
                    Console.WriteLine("I win!");
                    proceed = false;
                }
                if ((dice_1_1 + dice_1_2) == (dice_2_1 + dice_2_2))
                {
                    Console.WriteLine("Draw! Continuing");
                }
            }
            return true;
        }
    }
}
