using System;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string player, cpu;
            int random;
           
            bool PlayAgain = true;

            while (PlayAgain)
            {
                int ScorePlayer = 0;
                int ScoreCPU = 0;

                while (ScorePlayer < 3 && ScoreCPU < 3)
                {



                    Console.WriteLine("Choose between ROCK , PAPER and SCISSORS :     ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                    Random rnd = new Random();

                    random = rnd.Next(1, 4);

                    switch (random)
                    {
                        case 1:
                            cpu = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (player == "ROCK")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                ScorePlayer++;
                            }
                            else if (player == "SCISSORS")
                            {
                                Console.WriteLine("CPU wins!!\n\n");
                                ScoreCPU++;
                            }
                            break;
                        case 2:
                            cpu = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (player == "PAPER")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("CPU wins!!\n\n");
                                ScorePlayer++;
                            }
                            else if (player == "SCISSORS")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                ScoreCPU++;
                            }
                            break;
                        case 3:
                            cpu = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (player == "SCISSORS")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                ScorePlayer++;
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("CPU wins!!\n\n");
                                ScoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            ; break;
                    }
                    Console.WriteLine("\n\nScores:\tPlayert:\t{0}\tCPU:\t{1}", ScorePlayer,ScoreCPU);
                }
                if (ScorePlayer == 3)
                {
                    Console.WriteLine("Player Won!!!");
                }
                else if (ScoreCPU == 3)
                {
                    Console.WriteLine("CPU Won!!!");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play again???");
                string loop = Console.ReadLine();
                if(loop == "y")
                {
                    PlayAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    PlayAgain = false;

                }
                else
                {

                }
            }
        }
    }
}
