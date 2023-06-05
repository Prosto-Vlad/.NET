using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("How much passengers you want?");
            int count = Int32.Parse(Console.ReadLine());
            List<Passenger> pases = new List<Passenger>();
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                switch(rand.Next(1,4))
                {
                    case 1:
                        Passenger pas = new Passenger("Childe");
                        pases.Add(pas);
                        break;
                    case 2:
                        Passenger pas1 = new Passenger("Middle");
                        pases.Add(pas1);
                        break;
                    case 3:
                        Passenger pas2 = new Passenger("Old");
                        pases.Add(pas2);
                        break;
                }
            }

            Console.WriteLine("Which venixh you want&\n1 - bus\n2 - taxi");
            string temp = Console.ReadLine();
            if (temp == "1")
            {
                BussBuilder build = new BussBuilder();
                build.CreateType();
                build.CreateDriver();
                build.CreateMaxPeople();
                build.CreatePeople(pases);
                Console.WriteLine("Enter price of ticket");
                int price = Int32.Parse(Console.ReadLine());
                build.CreateTicketPrice(price);
                build.CalculatePrice();
                Venich bus = build.GetVenich();
                bus.PrintVenich();
                bus.StartTravel();
            }
            else if (temp == "2")
            {
                TaxiBuilder build = new TaxiBuilder();
                build.CreateType();
                build.CreateDriver();
                build.CreateMaxPeople();
                build.AddChair();
                build.CreatePeople(pases);
                Console.WriteLine("Enter price of ticket");
                int price = Int32.Parse(Console.ReadLine());
                build.CreateTicketPrice(price);
                build.CalculatePrice();
                Venich taxi = build.GetVenich();
                taxi.PrintVenich();
                taxi.StartTravel();
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }

    }
}