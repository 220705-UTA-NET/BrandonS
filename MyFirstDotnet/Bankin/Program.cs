using System;

namespace Banking{
    class Program{
        static void Main(string[] args){
            Account newAccount = new Account(1000,"Brandon");
            Account secondAccount =  new Account(500,"James");

            Console.WriteLine(newAccount.accountNumber.ToString());
            Console.WriteLine(secondAccount.accountNumber.ToString());

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
