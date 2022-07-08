namespace Banking{
    class Transaction{
        private double amount;
        private string note;
        private DateTime date;

        public Transaction(double amount, DateTime date, string note){
            this.amount = amount;
            this.date = date;
            this.note = note;
        }
    }
}