using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Magazine
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string periodicity { get; set; }
        public DateTime release_date { get; set; }
        public int Circulation { get; set; }

        public Magazine() { }
        public Magazine(int iD, string name, string periodicity, string release_date, int circulation)
        {
            ID = iD;
            this.name = name;
            this.periodicity = periodicity;
            string[] dateParts = release_date.Split('-');
            this.release_date = new DateTime(
                int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2])
                );
            Circulation = circulation;
        }

        public override string ToString()
        {
            return string.Format($"({this.ID}, {this.name}, {this.periodicity}, {this.release_date.ToShortDateString()}, {this.Circulation})");
        }
    }
}
