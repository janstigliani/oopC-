using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class VipCustomer : Customer
    {
        private string? NamePrefix { get; set; }
        private decimal NegativeThreshold { get; set; }

        public VipCustomer(string name, string surname, DateTime dob, string address, string mailAddress, decimal threshold) : base(name, surname, dob, address, mailAddress)
        {
            NegativeThreshold = threshold;
            NamePrefix = "ser";
        }

        public VipCustomer(string name, string surname, int year, int month, int day, string address, string mailAddress, decimal threshold) : base(name, surname, year, month, day, address, mailAddress)
        {
            NegativeThreshold = threshold;
            NamePrefix = "ser";
        }

        public override string ToString()
        {
            return NamePrefix + " " + base.ToString();
        }

        public override string welcome()
        {
            return base.welcome() + " " + NamePrefix;
        }

        public override string PrintAddress()
        {
            return NamePrefix + " " + base.PrintAddress();
        }
    }
}
