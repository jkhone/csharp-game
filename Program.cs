// SIMPLE ROCK, PAPER, SCISSORS GAME
// Use "dotnet run" in the integrated terminal to run 
// If you want to run in desktop terminal, change - "console": "integratedTerminal", - to "console": "internalConsole", - inside launch.json
// It asks you to put in either rock, paper, or scissors
// When you input something, the computer will randomly generate a choice and a score is added based on who wins
// First to three rounds wins and you have the option to replay
// Enjoy!

using System;
 
namespace consoleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            // setting player and cpu inputs for their choices
            string inputPlayer, inputCPU;
            // random number that is used to determine value for each choice so we can compare inputs
            int randomInt;
            // while playAgain is true, game will run still
            bool playAgain = true;
 
            while (playAgain)
            {
                // setting score, game will end when either player hits 3
                int playerScore = 0;
                int compScore = 0;
 
                while (playerScore < 3 && compScore < 3)
                {
                   
                    //  make choice, sets it to uppercase so it always matches
                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
 
                    // randomizes number to set as value to compare
                    Random rnd = new Random();
 
                    randomInt = rnd.Next(1, 4);
                    
                    // checks to see if input is valid choice, then checks for round winner
                    if (inputPlayer == "ROCK" | inputPlayer == "PAPER" | inputPlayer == "SCISSORS") {
                        switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                compScore++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                compScore++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                compScore++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                    } else {
                        Console.WriteLine("Invalid entry, choose again.");
                    }
                    // ^ does all checks to see who wins ^
                  
                    // keeps track of score
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",playerScore, compScore);
 
                }

                // determines winner
                if (playerScore == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (compScore == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                // new game 
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    playAgain = false;
                }
 
            }
        }
    }
}
