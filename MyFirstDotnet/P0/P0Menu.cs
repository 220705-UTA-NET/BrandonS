using System;

namespace P0{
    class MainMenu{
        static void Main(string[] args){
            int n;
            bool test = true;
            eightBall ball = new eightBall();
            RockPaperScissors rps = new RockPaperScissors();
            while(test){
                Console.WriteLine("What would you like to play!\n(Insert the number of the option.)");
                Console.WriteLine("1. Magic 8 Ball");
                Console.WriteLine("2. Rock Paper Scissors");
                Console.WriteLine("3. Tic Tac Toe");
                Console.WriteLine("4. Close the application\n");
                string input = Console.ReadLine();
                bool correctInput = int.TryParse(input,out n);
                if(correctInput){
                    int response = int.Parse(input);
                    switch(response){
                        case 1:
                            Console.WriteLine("Ask the magic 8 ball a question!");
                            Console.ReadLine();
                            ball.BallResponse();
                            Console.WriteLine("Thanks for asking!\n");
                            break;
                        case 2:
                            Console.WriteLine("How many rounds would you like to play?");
                            Console.WriteLine("Just one round (1)");
                            Console.WriteLine("Best 2 out of 3 (2)");
                            Console.WriteLine("Best 3 out of 5 (3)\n");
                            string numRounds = Console.ReadLine();
                            bool isInt = int.TryParse(input,out n);
                            // Console.WriteLine(isInt); ask about why this is always returning true
                            if(isInt){
                                switch(int.Parse(numRounds)){
                                    case 1:
                                        rps.playGame(1);
                                        break;
                                    case 2:
                                        rps.playGame(2);
                                        break;
                                    case 3:
                                        rps.playGame(3);
                                        break;
                                    default:
                                        Console.WriteLine("The number you input was not a valid option. Please try again\n");
                                        break;
                                }
                            }
                            else{
                                Console.WriteLine("Sorry the input was not correct please try again.\n");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Tic Tac Toe!");
                            break;
                        case 4:
                            Console.WriteLine("Thank you for playing!");
                            test = false;
                            break;
                    }
                }
                else{
                    Console.WriteLine("you fucked up your input");
                }
            }
        }
    }
}
