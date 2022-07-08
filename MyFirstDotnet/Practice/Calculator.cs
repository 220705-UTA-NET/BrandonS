using System;

namespace Practice{
    class Calculator{
        public void Calculate(int n){
            // print every multiple of 3 between 1 and n in reverse order
            // % is modulus

            // n % 3 == 0

            int start = n - (n % 3);
            while(start >= 3){
                Console.WriteLine(start);
                start -= 3;
            }
        }
    }
}