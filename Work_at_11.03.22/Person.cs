using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_at_11._03._22
{
    public class Person
    {
        private static int IDcount = 0;
        public int Id;
        public string name;
        public string surname;
        public bool pol;
        public DateTime dateBirth;
        public Image image;
        public string diagnoz;
        public string history;

        public Person(string name, string surname, bool pol, DateTime dateBirth, Image image, string diagnoz, string history) //конструктор с проверкой значений на null
        {
            Id = IDcount++;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.pol = pol;
            this.dateBirth = dateBirth;
            this.image = image;
            this.diagnoz = diagnoz;
            this.history = history;


        }
    }
}
