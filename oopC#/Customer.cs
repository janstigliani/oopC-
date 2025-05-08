using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class Customer: Person
    {
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public PaymentMethod? Mdp { get; set; }

        public Customer(string name, string surname, DateTime dob, string address, string mailAddress): base(name, surname, dob.Year, dob.Month, dob.Day)
        {
            Address = address;
            MailAddress = mailAddress;
        }

        public Customer(string name, string surname, int year, int month, int day, string address, string mailAddress): base(name, surname, year, month, day)
        {
            Address = address;
            MailAddress = mailAddress;
        }

        public override string ToString()
        {
            return "Cliente " + base.ToString();
        }

        public override string welcome()
        {
            return "Benvenuto";
        }

        public virtual string? PrintAddress()
        {
            if (Address != null)
            {
                //string[] addressArray = Address.Split(',');

                return Name + " " + Surname + "\n" + Address.Replace(", ", "\n");
            }
            else return null;
        }
    }

    public enum PaymentMethod
    {
        Iban, //possono essere associati ad un numero a scelta e chiamati con quel numero. es. Iban = 1000; in program c1.Mdp = 1000
        Cdc,
        Cash
    }
}
