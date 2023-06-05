using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Publisher
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public List<Magazine> Magazine { get; set; }

        public Publisher() { }
        public Publisher(int iD, string name, string city, string address, List<Magazine> magazines)
        {
            ID = iD;
            this.name = name;
            this.city = city;
            this.address = address;
            this.Magazine = magazines;
        }

        public override string ToString()
        {
            return string.Format($"({this.ID}, {this.name}, {this.city}, {this.address})");
        }
    }
}
