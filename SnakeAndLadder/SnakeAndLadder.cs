namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        public int player_Position = 0, DiceRoll;
        public void StartPosition()
        {
            Console.WriteLine("Game starts now...");
            Console.WriteLine("Starting position of player is: " + player_Position);
            Random random = new Random();

            while (player_Position < WINNING_POSITION)
            {
                DiceRoll = random.Next(1, 7);
                Console.WriteLine("\n Player gets Dice Number: " + DiceRoll);

                switch (random.Next(0, 3))
                {
                    case NO_PLAY:
                        Console.WriteLine("(No Play) Player Position: " + player_Position);
                        break;

                    case LADDER:
                        player_Position += DiceRoll;
                        if (player_Position > WINNING_POSITION)
                        {
                            player_Position -= DiceRoll;
                        }
                        Console.WriteLine("(Ladder) Player Position: " + player_Position);
                        break;
                    case SNAKE:
                        player_Position -= DiceRoll;
                        if (player_Position < 0)
                        {
                            player_Position = 0;
                        }
                        Console.WriteLine("(Snake) Player Position " + player_Position);
                        break;
                }

            }
            Console.WriteLine("\n Congratulations you Won");
        }
    }
}
