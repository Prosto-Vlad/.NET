using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Article
    {
        public int ID;
        public string name;
        public int ID_magazine;
        public DateTime input_data;

        public Article(int iD, string name, int iD_magazine, string input_data)
        {
            ID = iD;
            this.name = name;
            ID_magazine = iD_magazine;
            this.input_data = DateTime.Parse(input_data);
        }

        public override string ToString()
        {
            return string.Format($"({this.ID}, {this.name}, {this.ID_magazine}, {this.input_data.ToShortDateString()})");
        }
    }
}
