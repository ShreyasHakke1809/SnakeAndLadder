using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        public void StartPosition()
        {
            int startPosition = 0;
            int diceRoll;
            int option;
            Console.WriteLine("Starting position of player is : " + startPosition);
            Random random = new Random();
            diceRoll = random.Next(1,7);
            Console.WriteLine("Player gets dice number :" + diceRoll);
            option = random.Next(0,3);
            switch(option)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case LADDER:
                    startPosition += diceRoll;
                    Console.WriteLine("Ladder : "+ startPosition);
                    break;
                case SNAKE:
                    startPosition -= diceRoll;
                    Console.WriteLine("Snake : " + startPosition);
                    break;

            }
        }
    }
}
