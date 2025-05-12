using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace oopC_
{
    internal class BanckAccount
    {
        public string AccountNumber { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreationDate { get; set; } 
        public Employee Employee { get; set; }
        public List<Transaction> Transactions { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in Transactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        public BanckAccount(string accountNumber, Customer customer, Employee employee)
        {
            AccountNumber = accountNumber;
            Customer = customer;
            CreationDate = DateTime.Now;
            Employee = employee;
            Transactions = [];
        }

        protected decimal GetThreshold()
        {
            decimal threshold = 0;

            if (Customer is VipCustomer vipCustomer)
            {
                threshold = -vipCustomer.NegativeThreshold;
            }
            return threshold;
        }

        public virtual void Operate(decimal amount)
        {
            
            if (Balance + amount >= GetThreshold())
            {
                Transaction transaction = new Transaction
                {
                    Amount = amount,
                    Date = DateTime.Now,
                };
                Transactions.Add(transaction);
            }
        }

        public virtual string GenerateReport()
        {
            string report = "Account Number: " + AccountNumber + "\n";
            report += "Customer: " + Customer + "\n";
            report += "Creation Date: " + CreationDate.ToString("dd/MM/yyyy") + "\n";
            report += "Employee: " + Employee.Name + "\n";
            report += "Balance: " + Balance + "$\n";
            report += "Transactions:\n";
            foreach (var transaction in Transactions)
            {
                report += "Date: " + transaction.Date.ToString("dd/MM/yyyy") + ", Amount: " + transaction.Amount + "$\n";
            }
            return report;
        }
    }
}
