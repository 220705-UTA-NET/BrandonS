using System;

namespace Banking{
    class Program{
        static void Main(string[] args){
            Account newAccount = new SavingsAccount(1000,"Brandon");
            Account secondAccount =  new SavingsAccount(500,"James");
            Account thirdAccount = new SavingsAccount(3000,"John");

            Console.WriteLine(newAccount.accountNumber.ToString());
            Console.WriteLine(secondAccount.accountNumber.ToString());

            thirdAccount.accountNumber = 12345;
            Console.WriteLine(thirdAccount.accountNumber.ToString());

            secondAccount.deposit(150,"got paid");
            secondAccount.deposit(50,"dinner with friends");
            secondAccount.withdrawal(60,"new game");
            secondAccount.withdrawal(20,"Lunch");

            Console.WriteLine(secondAccount.getAccountHistory());
            Console.WriteLine(secondAccount.getBalance());

            // try{
            //     newAccount.deposit(1000);
            //     Console.WriteLine(newAccount.getBalance());
            // }
            // catch(Exception ex){
            //     Console.WriteLine(ex.Message);
            // }
            // try{
            //     newAccount.withdrawal(999);
            //     Console.WriteLine(newAccount.getBalance());
            // }
            // catch(Exception ex){
            //     Console.WriteLine(ex.Message);
            // }
            // try{
            //     newAccount.withdrawal(2);
            //     Console.WriteLine(newAccount.getBalance());
            // }
            // catch(Exception ex){
            //     Console.WriteLine(ex.Message);
            // }
            // try{
            //     newAccount.withdrawal(-51);
            //     Console.WriteLine(newAccount.getBalance());
            // }
            // catch(Exception ex){
            //     Console.WriteLine(ex.Message);
            // }
        }
    }
}
