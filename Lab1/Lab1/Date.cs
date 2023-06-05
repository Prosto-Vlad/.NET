using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Date
    {
        public int year;
        public int month;
        public int day;

        public Date(string date)
        {
            string[] dateParts = date.Split('-');
            this.year = int.Parse(dateParts[0]);
            this.month = int.Parse(dateParts[1]);
            this.day = int.Parse(dateParts[2]);
        }

        public override string ToString()
        {
            string temp = year.ToString();
            if (month < 10)
                temp += "-0" + month.ToString();
            else
                temp += '-' + month.ToString();

            if (day < 10)
                temp += "-0" + day.ToString();
            else
                temp += '-' + day.ToString();
            return temp;
        }
    }
}
