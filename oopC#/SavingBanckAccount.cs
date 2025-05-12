namespace oopC_
{
    internal class SavingBanckAccount : BanckAccount
    {
        public SavingBanckAccount(string accountNumber, Customer customer, Employee employee) : base(accountNumber, customer, employee)
        {
        }
        public override void Operate(decimal amount)
        {
            if (amount > GetThreshold())
            {
                decimal interest = amount * 0.05m;
                Transaction transaction = new Transaction
                {
                    Amount = interest,
                    Date = DateTime.Now,
                };
                Transactions.Add(transaction);
            }
            else
            {
                decimal penalty = amount * 0.03m;
                Transaction transaction = new Transaction
                {
                    Amount = penalty,
                    Date = DateTime.Now,
                };
                Transactions.Add(transaction);
            }

            base.Operate(amount);
        }
    }
}