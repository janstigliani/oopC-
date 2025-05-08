using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class Employee : Person
    {

        public string Branch { get; set; }
        public decimal Ral { get; set; }
        public ExperienceLevel Level { get; set; }

        public Employee(string name, string surname, int year, int month, int day, string branch) : base(name, surname, year, month, day)
        {
            Branch = branch;
        }

        public override string ToString()
        {
            return "Impiegato " + base.ToString();
        }

        public override string welcome()
        {
            return "Arbeit Macht Frei";
        }

        public enum ExperienceLevel
        {
            Apprentice = 1,
            Standard = 2,
            Expert = 3,
            Senior = 4,
        }
    }
}
