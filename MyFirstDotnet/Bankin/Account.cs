using System;

namespace Banking{
    class Account{
        // Fields and methods make up members
        // (access modifier) (type) (name) (initial value)
        protected double balance;
        public int accountNumber{get; set;}
        // makes public getting and setting of the variable. 
        // main difference is that if you were to create your own public getters and setters for a private variable you have more access to error checking functionalities.
        private string owner;
        private static int accountNumberSeed = 1234567890;

        // Constructor - the set of instructions on how to create an object of this type
        // (access modifier) (Class-name) (parameter list)
        public Account(double initialBalance, string owner){
            deposit(initialBalance);
            this.accountNumber = accountNumberSeed;
            accountNumberSeed++;
            this.owner = owner;
        }
        public string getBalance(){
            return balance.ToString();
        }
        public void deposit(double amount){
            if (amount <= 0 ){
                throw new ArgumentOutOfRangeException("invalid deposit amount");
            }
            else{
                balance += amount;
            }
        }
        public void withdrawal(double amount){
            if(amount <= 0 || amount > balance){
                throw new ArgumentOutOfRangeException("invalid withdrawal amount");
            }
            else{
                balance -= amount;
            }
        }
    }
}