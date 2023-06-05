using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Publisher
    {
        public int ID;
        public string name;
        public string city;
        public string address;
        public List<Magazine> magazines;

        public Publisher(int iD, string name, string city, string address, List<Magazine> magazines)
        {
            ID = iD;
            this.name = name;
            this.city = city;
            this.address = address;
            this.magazines = magazines;
        }

        public override string ToString()
        {
            return string.Format($"({this.ID}, {this.name}, {this.city}, {this.address})");
        }
    }
}
