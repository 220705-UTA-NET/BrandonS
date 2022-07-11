using System;

namespace P0{
    class eightBall{
        private string[] responses = new string[] {"Yes!", "No.", "Definitely!", "Not even a chance.", "You may rely on it", "Maybe", "Don't count on it.", "I'm not so sure..." };
        public void BallResponse(){
            var random = new Random();
            var range = random.Next(0,8);
            Console.WriteLine(responses[range]);
        }
    }
}