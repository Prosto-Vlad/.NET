using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class DataLink
    {
        public int ID1 { get; set; }
        public int ID2 { get; set; }

        public DataLink() { }
        public DataLink(int iD1, int iD2)
        {
            ID1 = iD1;
            ID2 = iD2;
        }

        public override string ToString()
        {
            return string.Format($"({this.ID1}, {this.ID2})");
        }
    }
}
