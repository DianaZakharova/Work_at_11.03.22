using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_at_11._03._22
{
    public class Person
    {
        public string name;
        public string surname;
        public bool pol;
        public DateTime dateBirth;

        public Person(string name, string surname, bool pol, DateTime dateBirth) //конструктор с проверкой значений на null
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.pol = pol;
            this.dateBirth = dateBirth;
        }
    }
}
