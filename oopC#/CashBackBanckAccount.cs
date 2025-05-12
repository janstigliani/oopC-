namespace oopC_
{
    internal class CashBackBanckAccount : BanckAccount
    {
        public CashBackBanckAccount(string v1, Customer v2, Employee e1) : base(v1, v2, e1)
        {
        }
        public override void Operate(decimal amount)
        {
            if (Balance + amount > GetThreshold())
            {
                decimal cashback = amount * 0.05m;
                Transaction transaction = new Transaction
                {
                    Amount = cashback,
                    Date = DateTime.Now,
                };
                Transactions.Add(transaction);
                base.Operate(amount);
            }
        }

        //public override string GenerateReport()
        //{
        //    string report = base.GenerateReport();
        //    report += "Cashback: " + Math.Round((Balance * 0.05m)*100)/100 + "$\n";
        //    return report;
        //}
    }
}