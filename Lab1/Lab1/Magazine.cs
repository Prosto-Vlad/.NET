using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Magazine
    {
        public int ID;
        public string name;
        public string periodicity;
        public DateTime release_date;
        public int Circulation;

        public Magazine(int iD, string name, string periodicity, string release_date, int circulation)
        {
            ID = iD;
            this.name = name;
            this.periodicity = periodicity;
            this.release_date = DateTime.Parse(release_date);
            Circulation = circulation;
        }

        public override string ToString()
        {
            return string.Format($"({this.ID}, {this.name}, {this.periodicity}, {this.release_date.ToShortDateString()}, {this.Circulation})");
        }
    }
}
