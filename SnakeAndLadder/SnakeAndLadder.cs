using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public void StartPosition()
        {
            int startPosition = 0;
            int diceRoll;
            Console.WriteLine("Starting position of player is : " + startPosition);
            Random random = new Random();
            diceRoll = random.Next(1,7);
            Console.WriteLine("Player gets dice number :" + diceRoll);
        }
    }
}
