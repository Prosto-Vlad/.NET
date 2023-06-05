using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Passenger
    {
        public enum Type
        {
            Childe,
            Middle,
            Old
        }
        public Type type { get; set; }

        public Passenger(string type)
        {
            this.type = (Type)Enum.Parse(typeof(Type), type);
        }
    }
}
