
namespace oopC_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime dob1 = new DateTime(2001,12,3);

            var c1 = new Customer("Pippo", "De Pippis", dob1, "Via Vanucci 3, 16123, Genova, Italy", "PippoDepippis@topoline.it");
            c1.Mdp = PaymentMethod.Iban;

            var c2 = new Customer("Clarabella", "Puzzolis", 1999, 11, 4, "Via Vanucci 4, 16123, Genova, Italy", "ClaraMoltoBella@topoline.it");

            var c3 = new Customer("Orazio", "Puzzolis", new DateTime(1997, 3, 27), "Via Vanucci 4, 16123, Genova, Italy", "Orazissimo@topoline.it");

            var v1 = new VipCustomer("Topolino", "Mouse", 1990, 2, 12, "Via Gramsci 4, 16123, Genova, Italy", "MickeyTopolino@topoline.it", 12000);

            var e1 = new Employee("Paperino", "Paperoni", 1992, 02, 13, "Genova1");
            e1.Level = (Employee.ExperienceLevel)2;

            //var p1 = new Person("quo", "paperoni", 2017, 07, 25)

            List<VipCustomer> vipCustomer = [];

            vipCustomer.Add(v1);
            //vipCustomer.Add(c1); //non si può fare
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);

            List<Customer> customers = new List<Customer>();

            customers.Add(c1);
            customers.Add(v1); //può fare tutto ciò che fa il padre quindi è un sottoinsieme dei Customer, e può stare in list

            List<Person> persons = new List<Person>();

            persons.Add(c1);
            persons.Add(c2);
            persons.Add(c3);
            persons.Add(v1);
            persons.Add(e1);

            foreach (var customer in customers)
            {
                //Console.WriteLine(customer.ToString());
                Console.WriteLine(customer.PrintAddress());
            }

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person.welcome());
            //}

        }
    }
}

//// to do: creare classe bank account. employee (chi lo ha creato), creationDate, transaction[], proprietario,
/// class transaction: amount e date
/// crea classi: account bancario cashBack, e account bancario Risparmio
/// motodo di tutti: operate, chiede quanto spostare, con + deposito, con - toglie, e aggiunge alla transaction; se andrei in negativo non va. Il conto si può calcolare ogni volta grazie a tutte le transaction.
/// save account aggiunge 2% in più per ogni transazione in ingresso, -3% per ogni transazione in uscito
/// cashback restituisce 5% di ogni transaction in uscita
/// to string method: nome proprietario, nome impiegato referente, data di creazione, lista transazioni, saldo