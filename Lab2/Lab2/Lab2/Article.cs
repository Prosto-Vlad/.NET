using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Article
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int ID_magazine { get; set; }
        public DateTime input_data { get; set; }

        public Article() { }
        public Article(int iD, string name, int iD_magazine, string input_data)
        {
            ID = iD;
            this.name = name;
            ID_magazine = iD_magazine;
            string[] dateParts = input_data.Split('-');
            this.input_data = new DateTime(
                int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2])
                );
        }

        public override string ToString()
        {
            return string.Format($"({this.ID}, {this.name}, {this.ID_magazine}, {this.input_data.ToShortDateString()})");
        }
    }
}
