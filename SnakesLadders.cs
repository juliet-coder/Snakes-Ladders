using System;

namespace Snakes_and_Ladders_Kata
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes and Ladders!");
            Console.WriteLine("Please enter the name of player one");

            String playerName = Console.ReadLine();

            Counter playerOne = new Counter(playerName);
            bool gameOver = false;
            Dice dice = new Dice();

            while (gameOver == false)
            {
                bool playerWon = false;
                Console.WriteLine("Press Any Key to Roll the Dice");
                Console.ReadLine();
                int roll = dice.rollDice();
                playerOne.Move(roll);
                playerWon = playerOne.checkWinner();
                if (playerWon == true)
                {
                    gameOver = true;
                    Console.WriteLine("The Dice roll was {0} so the player is now on square {1}", roll, playerOne.getLocation());
                    Console.WriteLine("The Player got to square 100");
                }
                else
                {                    
                    Console.WriteLine("The Dice roll was {0} so the player is now on square {1}", roll, playerOne.getLocation());
                }
                {

                }
            }

            Console.WriteLine("Thanks for Playing");
            Console.ReadLine();
        

        }
    }
}