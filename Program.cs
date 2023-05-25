using System;

namespace CarDriveGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Drive Game");
            Console.WriteLine("-------------------");

            // Initialize game variables
            bool isGameOver = false;
            int score = 0;

            // Game loop
            while (!isGameOver)
            {
                // Display instructions to the player
                Console.WriteLine("Press 'A' to accelerate, 'B' to brake, 'Q' to quit");

                // Read player input
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Console.Clear();

                // Process player input
                switch (char.ToUpper(keyInfo.KeyChar))
                {
                    case 'A':
                        // Increase the score when accelerating
                        score += 10;
                        Console.WriteLine("Accelerating! Score: " + score);
                        break;
                    case 'B':
                        // Decrease the score when braking
                        score -= 5;
                        Console.WriteLine("Braking! Score: " + score);
                        break;
                    case 'Q':
                        // Quit the game when the player presses 'Q'
                        isGameOver = true;
                        break;
                    default:
                        // Display an error message for invalid input
                        Console.WriteLine("Invalid input! Press 'A' to accelerate, 'B' to brake, 'Q' to quit");
                        break;
                }

                // Add a delay to make the game playable
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }

            // Game over message
            Console.WriteLine("Game Over");
            Console.WriteLine("Final Score: " + score);
        }
    }
}
