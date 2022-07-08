namespace Banking{
    class Transaction{
        public double amount;
        public string note;
        public DateTime date;
        private int transId;

        public Transaction(double amount, DateTime date, string note){
            this.amount = amount;
            this.date = date;
            this.note = note;
        }
    }
}