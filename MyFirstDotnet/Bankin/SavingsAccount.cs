namespace Banking{
    class SavingsAccount : Account{ // the ": Account" means we are EXTENDING the Account class.
    //The SavingsAccount type is an Account type.
    private double interestRate;
    
    public SavingsAccount(double initialBalance, string owner, double interestRate = .0003) : base(initialBalance, owner){
        this.interestRate = interestRate;
    }
    public void ApplyInterest(){
        double payment = this.balance * interestRate;
        this.deposit(payment);
    }

    public override string getBalance(){
        return "From Savings Accounts: " + base.getBalance();
    }
    // how to create a savings account from the account constructor
    }
}