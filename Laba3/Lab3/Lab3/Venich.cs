using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Venich
    {
        public enum Type
        {
            Bus,
            Taxi
        }
        public Type type { get; set; }
        public int Capacity { get; set; }
        public Driver Driver { get; set; }
        public int TicketPrice { get; set; }
        public int AllPrice { get; set; }
        public List<Passenger> Passengers { get; set; }
        public bool ChildeChair { get; set; }

        internal Driver Driver1
        {
            get => default;
            set
            {
            }
        }


        public Venich() { }

        public void PrintVenich()
        {
            Console.WriteLine("Venich info:");
            Console.WriteLine("Type: " + this.type.ToString());
            Console.WriteLine("Capacity: " + this.Capacity);
            Console.WriteLine("Ticket price: " + this.TicketPrice);
            Console.WriteLine("All price: " + this.AllPrice);
            Console.WriteLine("Count of passengers:" + this.Passengers.Count);
            Console.WriteLine("Driver class:" + this.Driver.category.ToString());
            Console.WriteLine("Has Child Seat: " + ChildeChair);
        }

        public bool CheckChilde()
        {
            if (ChildeChair == false && Passengers.Any(p => p.type.ToString() == "Childe") && type == Type.Taxi)
                return false;
            else
                return true;
        }

        public void StartTravel()
        {
            if (Passengers.Count > Capacity || !CheckChilde())
            {
                Console.WriteLine("Sorry, venich cant go now");
            }
            else
            {
                Console.WriteLine("Venich is ready to go. Price for travel will be " + this.AllPrice.ToString());
            }
        }
    }
}
