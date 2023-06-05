using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Author
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string organization { get; set; }

        public Author() { }
        public Author(int ID, string name, string surname, string patronymic, string organization)
        {
            this.ID = ID;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.organization = organization;
        }

        public override string ToString()
        {
            return string.Format($"({this.ID}, {this.name}, {this.surname}, {this.patronymic}, {this.organization})");
        }

    }
}
