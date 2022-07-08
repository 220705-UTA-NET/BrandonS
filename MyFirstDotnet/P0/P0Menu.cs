using System;

namespace P0{
    class MainMenu{
        static void Main(string[] args){
            int n;
            bool test = true;
            eightBall ball = new eightBall();
            while(test){
                Console.WriteLine("What would you like to play!\n(Insert the number of the option.)");
                Console.WriteLine("1. Magic 8 Ball");
                Console.WriteLine("2. Rock Paper Scissors");
                Console.WriteLine("3. Tic Tac Toe");
                Console.WriteLine("4. Close the application\n\n");
                string input = Console.ReadLine();
                bool correctInput = int.TryParse(input,out n);
                if(correctInput == true){
                    int response = int.Parse(input);
                    switch(response){
                        case 1:
                            Console.WriteLine("Ask the magic 8 ball a question!");
                            Console.ReadLine();
                            ball.BallResponse();
                            Console.WriteLine("Thanks for asking!");
                            break;
                        case 2:
                            Console.WriteLine("Time For Rock Paper Scissors!");
                            break;
                        case 3:
                            Console.WriteLine("Tic Tac Toe!");
                            break;
                    }
                }
            }
        }
    }
}
