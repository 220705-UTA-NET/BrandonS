using System;

namespace Practice{
    class Program{
        static void Main(string[] args){
            // Console.WriteLine("Please enter an integer: ");
            Calculator calc = new Calculator();

            // this comment block is for a try catch without a loop. following code uses TryParse and implements looping
            
            // try catch is a graceful way to handle exceptions. Don't let your application crash. Handle the exceptions.
            // try{
            //     int n;
            //     if(int.TryParse(Console.ReadLine(), out n)){ //dont force it and throw exceptions, try it first, and if it works then awesome
            //         //if not then let me know with a boolean value and decide what to do with it.
            //         calc.Calculate(n);
            //     }
            //     else{
            //         Console.WriteLine("Please enter an integer");
            //     }
            //      // returns a boolean so it can be used as a conditional
            //     int response = int.Parse(Console.ReadLine()); // Console.ReadLine() returns a string
            //     calc.Calculate(response);
            // }
            // catch(Exception ex){
            //     Console.WriteLine("This input is not the expected integer. Please try again.");
            //     return;
            // }
            int n;
            bool test;
            do{
                Console.WriteLine("Enter an Integer: ");
                string input = Console.ReadLine();
                test = int.TryParse(input,out n);
            }
            while(!test);
            calc.Calculate(n);
        }
    }
}