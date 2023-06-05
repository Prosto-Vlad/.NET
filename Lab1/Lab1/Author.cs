using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Author
    {
        public int ID;
        public string name;
        public string surname;
        public string patronymic;
        public string organization;

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
